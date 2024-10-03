using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;
using ZC.DomainModel.Core.CustomExceptions;
using ZC.DomainService.HttpClientCore;
using ZC.Service.AppEnviroment;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// https://sandbox.asaas.com/
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        public override string BaseUrl => string.Compare(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "Production", true) == 0 ? "https://api.asaas.com" : "https://sandbox.asaas.com";
        public override string UrlPrefix => string.Compare(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "Production", true) == 0 ? "/v3" : "/api/v3"; 

        private readonly ILogger<AsaasService> _logger;

        protected override JsonSerializerSettings RequestJsonSerializerSettings
        {
            get
            {
                return new JsonSerializerSettings()
                {

                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    DateFormatString = "yyyy-MM-dd",
                    NullValueHandling = NullValueHandling.Ignore
                };
            }
        }

        protected override JsonSerializerSettings ResposeJsonSerializerSettings
        {
            get
            {
                return new JsonSerializerSettings()
                {

                    DateFormatString = "yyyy-MM-dd",
                    NullValueHandling = NullValueHandling.Ignore
                };
            }
        }

        private readonly IHttpContextAccessor _httpContext;

        public AsaasService(
            ILogger<AsaasService> logger,
            ILogger<HttpServiceBase> httpServiceBaselogger,
            HttpClient httpClient,
            IHttpContextAccessor httpContext) : base(httpClient, httpServiceBaselogger)
        {
            _httpContext = httpContext;
            _logger = logger;

            _httpClient.DefaultRequestHeaders.UserAgent.Clear();
            _httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("ZDZCodeAgent", "001"));
        }

        private HttpClient BuildHttpClient(object param = null)
        {
            if (!_httpClient.DefaultRequestHeaders.Contains("access_token"))
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("access_token", ApiKey);
            }
            else if (_httpClient.DefaultRequestHeaders.GetValues("access_token").First() != ApiKey)
            {
                _httpClient.DefaultRequestHeaders.Remove("access_token");
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("access_token", ApiKey);
            }

            return _httpClient;
        }

        protected string ApiKey => Environment.GetEnvironmentVariable("ASAAS_TOKEN");

        public override async Task OnPreRequest(HttpClient httpClient, string requestUriWithParam, object content = null)
        {
            await base.OnPreRequest(httpClient, requestUriWithParam, content);

            BuildHttpClient(content);
        }

        protected override string GetQueryString(object obj)
        {
            return base.GetQueryString(obj)?.Replace("dateCreated=", "dateCreated[ge]="); ;
        }

        public override Task OnRequestEnd(HttpResponseMessage response)
        {
            try
            {

                BaseAsaasResponse baseResult = new BaseAsaasResponse();

                if (response.Headers.Contains("RateLimit-Limit"))
                {
                    baseResult.HasRateLimit = true;

                    int.TryParse(response.Headers.GetValues("RateLimit-Limit").FirstOrDefault(), out int RateLimitLimit);

                    baseResult.RateLimitLimit = RateLimitLimit;
                }

                if (response.Headers.Contains("RateLimit-Limit"))
                {
                    baseResult.HasRateLimit = true;

                    int.TryParse(response.Headers.GetValues("RateLimit-Remaining").FirstOrDefault(), out int RateLimitRemaining);

                    baseResult.RateLimitRemaining = RateLimitRemaining;
                }

                if (response.Headers.Contains("RateLimit-Limit"))
                {
                    baseResult.HasRateLimit = true;

                    int.TryParse(response.Headers.GetValues("RateLimit-Reset").FirstOrDefault(), out int RateLimitReset);

                    baseResult.RateLimitReset = RateLimitReset;
                }
            }
            catch
            {

            }

            return base.OnRequestEnd(response);
        }

        public override async Task<T> DeserializeResult<T>(HttpResponseMessage response)
        {
            string responseData = await response.Content.ReadAsStringAsync();

            responseData = ClearJsonData(responseData);

            return JsonConvert.DeserializeObject<T>(responseData, ResposeJsonSerializerSettings);
        }

        private string ClearJsonData(string responseData)
        {
            int last1 = responseData.LastIndexOf("}");
            int last2 = responseData.LastIndexOf("]");

            return responseData.Substring(0, Math.Max(last1, last2) + 1);
        }

        public override async Task OnRequestError(HttpResponseMessage response)
        {
            string responseData = await response.Content.ReadAsStringAsync();

            string requestBody = "";

            if (response?.RequestMessage?.Content != null)
            {
                requestBody = await response?.RequestMessage?.Content?.ReadAsStringAsync();
            }

            _logger.LogCritical(responseData);

            throw UserFriendlyException.Error(responseData, response.StatusCode);
        }
    }
}