using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.PaymentRefund.Request;
using ZDZCode.Payments.Asaas.DTO.PaymentRefund.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a estornos.
    /// Documentação: https://docs.asaas.com/reference/estorno
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Solicita o estorno de um pagamento.
        /// </summary>
        public async Task<PaymentRefundResponse> RefundPayment(PaymentRefundRequest request)
        {
            return await PostAsync<PaymentRefundResponse>("/refunds", request);
        }

        /// <summary>
        /// Lista os estornos existentes.
        /// </summary>
        public async Task<ListPageResponse<PaymentRefundResponse>> ListRefunds(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<PaymentRefundResponse>>("/refunds", request);
        }

        /// <summary>
        /// Recupera um estorno pelo identificador.
        /// </summary>
        public async Task<PaymentRefundResponse> GetRefundById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<PaymentRefundResponse>($"/refunds/{id}", request);
        }
    }
}
