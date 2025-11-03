using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Webhook.Request;
using ZDZCode.Payments.Asaas.DTO.Webhook.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a webhooks.
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria um novo webhook.
        /// Documentação: https://docs.asaas.com/reference/criar-webhook
        /// </summary>
        /// <param name="request">Dados do webhook a ser criado.</param>
        /// <returns>Resposta contendo os dados do webhook criado.</returns>
        public async Task<WebhookResponse> CreateWebhook(WebhookRequest request)
        {
            return await PostAsync<WebhookResponse>("/webhook", request);
        }

        /// <summary>
        /// Recupera um webhook pelo identificador.
        /// Documentação: https://docs.asaas.com/reference/recuperar-webhook
        /// </summary>
        /// <param name="id">ID do webhook.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Dados do webhook.</returns>
        public async Task<WebhookResponse> GetWebhook(string id, BaseAsaasRequest? request = null)
        {
            return await GetAsync<WebhookResponse>($"/webhook/{id}", request);
        }

        /// <summary>
        /// Lista os webhooks cadastrados.
        /// Documentação: https://docs.asaas.com/reference/listar-webhooks
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de webhooks.</returns>
        public async Task<ListPageResponse<WebhookResponse>> ListWebhooks(BaseAsaasRequest? request = null)
        {
            return await GetAsync<ListPageResponse<WebhookResponse>>("/webhook", request);
        }

        /// <summary>
        /// Remove um webhook existente.
        /// Documentação: https://docs.asaas.com/reference/remover-webhook
        /// </summary>
        /// <param name="id">ID do webhook a ser removido.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta da operação de remoção.</returns>
        public async Task<ValueResponse> DeleteWebhook(string id, BaseAsaasRequest? request = null)
        {
            return await DeleteAsync<ValueResponse>($"/webhook/{id}", request);
        }

        /// <summary>
        /// Cria um webhook para eventos de notas fiscais.
        /// Documentação: https://docs.asaas.com/reference/criar-webhook-nota-fiscal
        /// </summary>
        /// <param name="request">Dados do webhook a ser criado.</param>
        /// <returns>Resposta contendo os dados do webhook criado.</returns>
        public async Task<WebhookResponse> CreateInvoiceWebhook(WebhookRequest request)
        {
            return await PostAsync<WebhookResponse>("/webhook/invoice", request);
        }

        /// <summary>
        /// Lista os webhooks de notas fiscais cadastrados.
        /// Documentação: https://docs.asaas.com/reference/listar-webhooks-nota-fiscal
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de webhooks de notas fiscais.</returns>
        public async Task<ListPageResponse<WebhookResponse>> ListInvoiceWebhooks(BaseAsaasRequest? request = null)
        {
            return await GetAsync<ListPageResponse<WebhookResponse>>("/webhook/invoice", request);
        }

        /// <summary>
        /// Cria um webhook para eventos de recarga de celular.
        /// Documentação: https://docs.asaas.com/reference/criar-webhook-recarga-celular
        /// </summary>
        /// <param name="request">Dados do webhook a ser criado.</param>
        /// <returns>Resposta contendo os dados do webhook criado.</returns>
        public async Task<WebhookResponse> CreateMobilePhoneRechargeWebhook(WebhookRequest request)
        {
            return await PostAsync<WebhookResponse>("/webhook/mobilePhoneRecharge", request);
        }

        /// <summary>
        /// Lista os webhooks de recarga de celular cadastrados.
        /// Documentação: https://docs.asaas.com/reference/listar-webhooks-recarga-celular
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de webhooks de recarga de celular.</returns>
        public async Task<ListPageResponse<WebhookResponse>> ListMobilePhoneRechargeWebhooks(BaseAsaasRequest? request = null)
        {
            return await GetAsync<ListPageResponse<WebhookResponse>>("/webhook/mobilePhoneRecharge", request);
        }
    }
}
