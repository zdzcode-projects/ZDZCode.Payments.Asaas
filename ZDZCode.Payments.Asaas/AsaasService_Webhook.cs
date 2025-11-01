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

        /// <summary>
        /// Cria um webhook para eventos de notas fiscais.
        /// </summary>
        public async Task<WebhookResponse> CreateInvoiceWebhook(WebhookRequest request)
        {
            return await PostAsync<WebhookResponse>("/webhook/invoice", request);
        }

        /// <summary>
        /// Lista os webhooks de notas fiscais cadastrados.
        /// </summary>
        public async Task<ListPageResponse<WebhookResponse>> ListInvoiceWebhooks(BaseAsaasRequest? request = null)
        {
            return await GetAsync<ListPageResponse<WebhookResponse>>("/webhook/invoice", request);
        }

        /// <summary>
        /// Cria um webhook para eventos de recarga de celular.
        /// </summary>
        public async Task<WebhookResponse> CreateMobilePhoneRechargeWebhook(WebhookRequest request)
        {
            return await PostAsync<WebhookResponse>("/webhook/mobilePhoneRecharge", request);
        }

        /// <summary>
        /// Lista os webhooks de recarga de celular cadastrados.
        /// </summary>
        public async Task<ListPageResponse<WebhookResponse>> ListMobilePhoneRechargeWebhooks(BaseAsaasRequest? request = null)
        {
            return await GetAsync<ListPageResponse<WebhookResponse>>("/webhook/mobilePhoneRecharge", request);
        }
    }
}
