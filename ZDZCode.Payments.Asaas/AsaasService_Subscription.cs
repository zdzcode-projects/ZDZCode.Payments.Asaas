using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Subscription.Request;
using ZDZCode.Payments.Asaas.DTO.Subscription.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria uma nova assinatura.
        /// </summary>
        public async Task<SubscriptionResponse> CreateSubscription(SubscriptionRequest request)
        {
            return await PostAsync<SubscriptionResponse>("/subscriptions", request);
        }

        /// <summary>
        /// Lista as assinaturas existentes.
        /// </summary>
        public async Task<ListPageResponse<SubscriptionResponse>> ListSubscriptions(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<SubscriptionResponse>>("/subscriptions", request);
        }

        /// <summary>
        /// Recupera uma assinatura pelo identificador.
        /// </summary>
        public async Task<SubscriptionResponse> GetSubscriptionById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<SubscriptionResponse>($"/subscriptions/{id}", request);
        }

        /// <summary>
        /// Atualiza uma assinatura existente.
        /// </summary>
        public async Task<SubscriptionResponse> UpdateSubscription(string id, SubscriptionRequest request)
        {
            return await PostAsync<SubscriptionResponse>($"/subscriptions/{id}", request);
        }

        /// <summary>
        /// Cancela uma assinatura existente.
        /// </summary>
        public async Task<ValueResponse> DeleteSubscription(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<ValueResponse>($"/subscriptions/{id}", request);
        }

        /// <summary>
        /// Configura a emissão automática de notas fiscais para uma assinatura.
        /// </summary>
        public async Task<SubscriptionInvoiceSettingsResponse> ConfigureSubscriptionInvoiceSettings(string id, SubscriptionInvoiceSettingsRequest request)
        {
            return await PostAsync<SubscriptionInvoiceSettingsResponse>($"/subscriptions/{id}/invoiceSettings", request);
        }

        /// <summary>
        /// Recupera as configurações de nota fiscal de uma assinatura.
        /// </summary>
        public async Task<SubscriptionInvoiceSettingsResponse> GetSubscriptionInvoiceSettings(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<SubscriptionInvoiceSettingsResponse>($"/subscriptions/{id}/invoiceSettings", request);
        }

        /// <summary>
        /// Lista os pagamentos de uma assinatura.
        /// </summary>
        public async Task<ListPageResponse<DTO.Payment.Response.CreateNewPaymentResponse>> ListSubscriptionPayments(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<DTO.Payment.Response.CreateNewPaymentResponse>>($"/subscriptions/{id}/payments", request);
        }

        /// <summary>
        /// Recupera o carnê de uma assinatura.
        /// </summary>
        public async Task<ValueResponse> GetSubscriptionPaymentBook(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<ValueResponse>($"/subscriptions/{id}/paymentBook", request);
        }

        /// <summary>
        /// Lista as notas fiscais de uma assinatura.
        /// </summary>
        public async Task<ListPageResponse<DTO.Invoice.Response.InvoiceResponse>> ListSubscriptionInvoices(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<DTO.Invoice.Response.InvoiceResponse>>($"/subscriptions/{id}/invoices", request);
        }

        /// <summary>
        /// Remove as configurações de nota fiscal de uma assinatura.
        /// </summary>
        public async Task<ValueResponse> DeleteSubscriptionInvoiceSettings(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<ValueResponse>($"/subscriptions/{id}/invoiceSettings", request);
        }
    }
}
