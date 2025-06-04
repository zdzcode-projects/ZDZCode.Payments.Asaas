using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.PaymentLink.Request;
using ZDZCode.Payments.Asaas.DTO.PaymentLink.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria um novo link de pagamento.
        /// </summary>
        public async Task<PaymentLinkResponse> CreatePaymentLink(PaymentLinkRequest request)
        {
            return await PostAsync<PaymentLinkResponse>("/paymentLinks", request);
        }

        /// <summary>
        /// Obtém um link de pagamento através do identificador retornado pela API.
        /// </summary>
        public async Task<PaymentLinkResponse> GetPaymentLink(string id, BaseAsaasRequest? request = null)
        {
            return await GetAsync<PaymentLinkResponse>($"/paymentLinks/{id}", request);
        }

        /// <summary>
        /// Lista links de pagamento cadastrados.
        /// </summary>
        public async Task<ListPageResponse<PaymentLinkResponse>> ListPaymentLinks(BaseAsaasRequest? request = null)
        {
            return await GetAsync<ListPageResponse<PaymentLinkResponse>>("/paymentLinks", request);
        }
    }
}
