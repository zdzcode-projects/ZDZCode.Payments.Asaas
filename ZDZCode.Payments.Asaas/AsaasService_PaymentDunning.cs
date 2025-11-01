using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.PaymentDunning.Request;
using ZDZCode.Payments.Asaas.DTO.PaymentDunning.Response;

namespace ZDZCode.Payments.Asaas
{
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
    }
}
