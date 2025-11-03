using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Subscription.Request;
using ZDZCode.Payments.Asaas.DTO.Subscription.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a assinaturas (subscriptions).
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria uma nova assinatura.
        /// Documentação: https://docs.asaas.com/reference/criar-assinatura
        /// </summary>
        /// <param name="request">Dados da assinatura a ser criada.</param>
        /// <returns>Resposta contendo os dados da assinatura criada.</returns>
        public async Task<SubscriptionResponse> CreateSubscription(SubscriptionRequest request)
        {
            return await PostAsync<SubscriptionResponse>("/subscriptions", request);
        }

        /// <summary>
        /// Lista as assinaturas existentes.
        /// Documentação: https://docs.asaas.com/reference/listar-assinaturas
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de assinaturas.</returns>
        public async Task<ListPageResponse<SubscriptionResponse>> ListSubscriptions(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<SubscriptionResponse>>("/subscriptions", request);
        }

        /// <summary>
        /// Recupera uma assinatura pelo identificador.
        /// Documentação: https://docs.asaas.com/reference/recuperar-uma-unica-assinatura
        /// </summary>
        /// <param name="id">ID da assinatura.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Dados da assinatura.</returns>
        public async Task<SubscriptionResponse> GetSubscriptionById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<SubscriptionResponse>($"/subscriptions/{id}", request);
        }

        /// <summary>
        /// Atualiza uma assinatura existente.
        /// Documentação: https://docs.asaas.com/reference/atualizar-assinatura
        /// </summary>
        /// <param name="id">ID da assinatura a ser atualizada.</param>
        /// <param name="request">Dados atualizados da assinatura.</param>
        /// <returns>Resposta contendo os dados da assinatura atualizada.</returns>
        public async Task<SubscriptionResponse> UpdateSubscription(string id, SubscriptionRequest request)
        {
            return await PostAsync<SubscriptionResponse>($"/subscriptions/{id}", request);
        }

        /// <summary>
        /// Cancela uma assinatura existente.
        /// Documentação: https://docs.asaas.com/reference/deletar-assinatura
        /// </summary>
        /// <param name="id">ID da assinatura a ser cancelada.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta da operação de cancelamento.</returns>
        public async Task<ValueResponse> DeleteSubscription(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<ValueResponse>($"/subscriptions/{id}", request);
        }

        /// <summary>
        /// Configura a emissão automática de notas fiscais para uma assinatura.
        /// Documentação: https://docs.asaas.com/reference/configurar-emissao-automatica-de-nf-e-em-assinatura
        /// </summary>
        /// <param name="id">ID da assinatura.</param>
        /// <param name="request">Configurações de emissão de nota fiscal.</param>
        /// <returns>Resposta contendo as configurações de nota fiscal.</returns>
        public async Task<SubscriptionInvoiceSettingsResponse> ConfigureSubscriptionInvoiceSettings(string id, SubscriptionInvoiceSettingsRequest request)
        {
            return await PostAsync<SubscriptionInvoiceSettingsResponse>($"/subscriptions/{id}/invoiceSettings", request);
        }

        /// <summary>
        /// Recupera as configurações de nota fiscal de uma assinatura.
        /// Documentação: https://docs.asaas.com/reference/recuperar-configuracoes-de-nf-e-de-assinatura
        /// </summary>
        /// <param name="id">ID da assinatura.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Configurações de nota fiscal da assinatura.</returns>
        public async Task<SubscriptionInvoiceSettingsResponse> GetSubscriptionInvoiceSettings(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<SubscriptionInvoiceSettingsResponse>($"/subscriptions/{id}/invoiceSettings", request);
        }

        /// <summary>
        /// Lista os pagamentos de uma assinatura.
        /// Documentação: https://docs.asaas.com/reference/listar-pagamentos-de-assinatura
        /// </summary>
        /// <param name="id">ID da assinatura.</param>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de pagamentos da assinatura.</returns>
        public async Task<ListPageResponse<DTO.Payment.Response.CreateNewPaymentResponse>> ListSubscriptionPayments(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<DTO.Payment.Response.CreateNewPaymentResponse>>($"/subscriptions/{id}/payments", request);
        }

        /// <summary>
        /// Recupera o carnê de uma assinatura.
        /// Documentação: https://docs.asaas.com/reference/recuperar-carne-de-assinatura
        /// </summary>
        /// <param name="id">ID da assinatura.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Carnê da assinatura.</returns>
        public async Task<ValueResponse> GetSubscriptionPaymentBook(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<ValueResponse>($"/subscriptions/{id}/paymentBook", request);
        }

        /// <summary>
        /// Lista as notas fiscais de uma assinatura.
        /// Documentação: https://docs.asaas.com/reference/listar-notas-fiscais-de-assinatura
        /// </summary>
        /// <param name="id">ID da assinatura.</param>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de notas fiscais da assinatura.</returns>
        public async Task<ListPageResponse<DTO.Invoice.Response.InvoiceResponse>> ListSubscriptionInvoices(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<DTO.Invoice.Response.InvoiceResponse>>($"/subscriptions/{id}/invoices", request);
        }

        /// <summary>
        /// Remove as configurações de nota fiscal de uma assinatura.
        /// Documentação: https://docs.asaas.com/reference/remover-configuracoes-de-nf-e-de-assinatura
        /// </summary>
        /// <param name="id">ID da assinatura.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta da operação de remoção.</returns>
        public async Task<ValueResponse> DeleteSubscriptionInvoiceSettings(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<ValueResponse>($"/subscriptions/{id}/invoiceSettings", request);
        }
    }
}
