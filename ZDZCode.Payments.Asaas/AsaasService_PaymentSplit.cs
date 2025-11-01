using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.PaymentSplit.Request;
using ZDZCode.Payments.Asaas.DTO.PaymentSplit.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Recupera os splits de um pagamento.
        /// </summary>
        public async Task<ListPageResponse<PaymentSplitResponse>> GetPaymentSplits(string paymentId, BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<PaymentSplitResponse>>($"/payments/{paymentId}/splits", request);
        }
    }
}
