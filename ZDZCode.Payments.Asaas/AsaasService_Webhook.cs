using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Webhook.Request;
using ZDZCode.Payments.Asaas.DTO.Webhook.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria um novo webhook.
        /// </summary>
        public async Task<WebhookResponse> CreateWebhook(WebhookRequest request)
        {
            return await PostAsync<WebhookResponse>("/webhook", request);
        }

        /// <summary>
        /// Recupera um webhook pelo identificador.
        /// </summary>
        public async Task<WebhookResponse> GetWebhook(string id, BaseAsaasRequest? request = null)
        {
            return await GetAsync<WebhookResponse>($"/webhook/{id}", request);
        }

        /// <summary>
        /// Lista os webhooks cadastrados.
        /// </summary>
        public async Task<ListPageResponse<WebhookResponse>> ListWebhooks(BaseAsaasRequest? request = null)
        {
            return await GetAsync<ListPageResponse<WebhookResponse>>("/webhook", request);
        }

        /// <summary>
        /// Remove um webhook existente.
        /// </summary>
        public async Task<ValueResponse> DeleteWebhook(string id, BaseAsaasRequest? request = null)
        {
            return await DeleteAsync<ValueResponse>($"/webhook/{id}", request);
        }
    }
}
