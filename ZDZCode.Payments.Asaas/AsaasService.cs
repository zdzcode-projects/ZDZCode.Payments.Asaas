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
    /// Serviço principal para integração com a API Asaas (https://www.asaas.com).
    /// Fornece acesso a todos os recursos da plataforma de pagamentos Asaas.
    /// Documentação: https://docs.asaas.com/
    /// Ambiente Sandbox: https://sandbox.asaas.com/
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Obtém a URL base da API, dependendo do ambiente (Production ou Sandbox).
        /// </summary>
        public override string BaseUrl => string.Compare(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "Production", true) == 0 ? "https://api.asaas.com" : "https://sandbox.asaas.com";
        
        /// <summary>
        /// Obtém o prefixo da URL da API (/v3 para produção, /api/v3 para sandbox).
        /// </summary>
        public override string UrlPrefix => string.Compare(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "Production", true) == 0 ? "/v3" : "/api/v3"; 

        private readonly ILogger<AsaasService> _logger;

        /// <summary>
        /// Configurações de serialização JSON para requisições enviadas à API.
        /// Utiliza camelCase para nomes de propriedades e formato de data yyyy-MM-dd.
        /// </summary>
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

        /// <summary>
        /// Configurações de serialização JSON para respostas recebidas da API.
        /// Utiliza formato de data yyyy-MM-dd.
        /// </summary>
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

        /// <summary>
        /// Construtor do serviço Asaas.
        /// </summary>
        /// <param name="logger">Logger específico para AsaasService.</param>
        /// <param name="httpServiceBaselogger">Logger para a classe base HttpServiceBase.</param>
        /// <param name="httpClient">Cliente HTTP para realizar requisições.</param>
        /// <param name="httpContext">Acessor do contexto HTTP.</param>
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

        /// <summary>
        /// Configura o HttpClient com o token de acesso necessário para autenticação na API.
        /// </summary>
        /// <param name="param">Parâmetro opcional.</param>
        /// <returns>HttpClient configurado.</returns>
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

        /// <summary>
        /// Chave de API para autenticação no Asaas, obtida da variável de ambiente ASAAS_TOKEN.
        /// </summary>
        protected string ApiKey => Environment.GetEnvironmentVariable("ASAAS_TOKEN");

        /// <summary>
        /// Hook executado antes de cada requisição para configurar o cliente HTTP.
        /// </summary>
        /// <param name="httpClient">Cliente HTTP.</param>
        /// <param name="requestUriWithParam">URI da requisição com parâmetros.</param>
        /// <param name="content">Conteúdo da requisição.</param>
        public override async Task OnPreRequest(HttpClient httpClient, string requestUriWithParam, object content = null)
        {
            await base.OnPreRequest(httpClient, requestUriWithParam, content);

            BuildHttpClient(content);
        }

        /// <summary>
        /// Converte objeto em query string, adaptando o formato de dateCreated para o padrão da API Asaas.
        /// </summary>
        /// <param name="obj">Objeto a ser convertido.</param>
        /// <returns>Query string formatada.</returns>
        protected override string GetQueryString(object obj)
        {
            return base.GetQueryString(obj)?.Replace("dateCreated=", "dateCreated[ge]="); ;
        }

        /// <summary>
        /// Hook executado ao final de cada requisição para extrair informações de rate limiting.
        /// </summary>
        /// <param name="response">Resposta HTTP.</param>
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

        /// <summary>
        /// Desserializa a resposta HTTP em um objeto do tipo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo do objeto de retorno.</typeparam>
        /// <param name="response">Resposta HTTP.</param>
        /// <returns>Objeto desserializado.</returns>
        public override async Task<T> DeserializeResult<T>(HttpResponseMessage response)
        {
            string responseData = await response.Content.ReadAsStringAsync();

            responseData = ClearJsonData(responseData);

            return JsonConvert.DeserializeObject<T>(responseData, ResposeJsonSerializerSettings);
        }

        /// <summary>
        /// Limpa dados JSON removendo caracteres após o último } ou ].
        /// </summary>
        /// <param name="responseData">Dados JSON a serem limpos.</param>
        /// <returns>JSON limpo.</returns>
        private string ClearJsonData(string responseData)
        {
            int last1 = responseData.LastIndexOf("}");
            int last2 = responseData.LastIndexOf("]");

            return responseData.Substring(0, Math.Max(last1, last2) + 1);
        }

        /// <summary>
        /// Hook executado quando ocorre erro na requisição.
        /// Registra o erro e lança uma exceção amigável ao usuário.
        /// </summary>
        /// <param name="response">Resposta HTTP com erro.</param>
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