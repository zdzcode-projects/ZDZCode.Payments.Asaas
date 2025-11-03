using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.PaymentSplit.Request;
using ZDZCode.Payments.Asaas.DTO.PaymentSplit.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a split de pagamentos.
    /// Documentação: https://docs.asaas.com/reference/split
    /// </summary>
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
