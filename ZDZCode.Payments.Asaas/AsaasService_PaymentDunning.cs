using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.PaymentDunning.Request;
using ZDZCode.Payments.Asaas.DTO.PaymentDunning.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a negativação.
    /// Documentação: https://docs.asaas.com/reference/negativacao
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria uma negativação para um pagamento.
        /// </summary>
        public async Task<PaymentDunningResponse> CreatePaymentDunning(PaymentDunningRequest request)
        {
            return await PostAsync<PaymentDunningResponse>("/paymentDunnings", request);
        }

        /// <summary>
        /// Lista as negativações existentes.
        /// </summary>
        public async Task<ListPageResponse<PaymentDunningResponse>> ListPaymentDunnings(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<PaymentDunningResponse>>("/paymentDunnings", request);
        }

        /// <summary>
        /// Recupera uma negativação pelo identificador.
        /// </summary>
        public async Task<PaymentDunningResponse> GetPaymentDunningById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<PaymentDunningResponse>($"/paymentDunnings/{id}", request);
        }

        /// <summary>
        /// Cancela uma negativação existente.
        /// </summary>
        public async Task<ValueResponse> CancelPaymentDunning(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<ValueResponse>($"/paymentDunnings/{id}/cancel", request);
        }

        /// <summary>
        /// Simula uma negativação.
        /// </summary>
        public async Task<PaymentDunningResponse> SimulatePaymentDunning(PaymentDunningRequest request)
        {
            return await PostAsync<PaymentDunningResponse>("/paymentDunnings/simulate", request);
        }

        /// <summary>
        /// Recupera o histórico de uma negativação.
        /// </summary>
        public async Task<PaymentDunningHistoryResponse> GetPaymentDunningHistory(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<PaymentDunningHistoryResponse>($"/paymentDunnings/{id}/history", request);
        }

        /// <summary>
        /// Lista os pagamentos parciais de uma negativação.
        /// </summary>
        public async Task<ListPageResponse<DTO.Payment.Response.CreateNewPaymentResponse>> ListPaymentDunningPartialPayments(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<DTO.Payment.Response.CreateNewPaymentResponse>>($"/paymentDunnings/{id}/partialPayments", request);
        }

        /// <summary>
        /// Lista as cobranças disponíveis para negativação.
        /// </summary>
        public async Task<ListPageResponse<DTO.Payment.Response.CreateNewPaymentResponse>> ListPaymentsAvailableForDunning(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<DTO.Payment.Response.CreateNewPaymentResponse>>("/paymentDunnings/paymentsAvailableForDunning", request);
        }

        /// <summary>
        /// Envia documentos para uma negativação.
        /// </summary>
        public async Task<ValueResponse> SendPaymentDunningDocuments(string id, PaymentDunningRequest request)
        {
            return await PostAsync<ValueResponse>($"/paymentDunnings/{id}/documents", request);
        }
    }
}
