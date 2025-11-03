using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.PaymentLink.Request;
using ZDZCode.Payments.Asaas.DTO.PaymentLink.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a link de pagamento.
    /// Documentação: https://docs.asaas.com/reference/link-de-pagamento
    /// </summary>
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

        /// <summary>
        /// Atualiza um link de pagamento existente.
        /// </summary>
        public async Task<PaymentLinkResponse> UpdatePaymentLink(string id, PaymentLinkRequest request)
        {
            return await PutAsync<PaymentLinkResponse>($"/paymentLinks/{id}", request);
        }

        /// <summary>
        /// Remove um link de pagamento existente.
        /// </summary>
        public async Task<ValueResponse> DeletePaymentLink(string id, BaseAsaasRequest? request = null)
        {
            return await DeleteAsync<ValueResponse>($"/paymentLinks/{id}", request);
        }

        /// <summary>
        /// Adiciona uma imagem a um link de pagamento.
        /// </summary>
        public async Task<PaymentLinkImageResponse> AddPaymentLinkImage(string id, PaymentLinkImageRequest request)
        {
            return await PostAsync<PaymentLinkImageResponse>($"/paymentLinks/{id}/images", request);
        }

        /// <summary>
        /// Lista as imagens de um link de pagamento.
        /// </summary>
        public async Task<ListPageResponse<PaymentLinkImageResponse>> ListPaymentLinkImages(string id, BaseAsaasRequest? request = null)
        {
            return await GetAsync<ListPageResponse<PaymentLinkImageResponse>>($"/paymentLinks/{id}/images", request);
        }

        /// <summary>
        /// Remove uma imagem de um link de pagamento.
        /// </summary>
        public async Task<ValueResponse> DeletePaymentLinkImage(string paymentLinkId, string imageId, BaseAsaasRequest? request = null)
        {
            return await DeleteAsync<ValueResponse>($"/paymentLinks/{paymentLinkId}/images/{imageId}", request);
        }

        /// <summary>
        /// Restaura um link de pagamento removido.
        /// </summary>
        public async Task<PaymentLinkResponse> RestorePaymentLink(string id, BaseAsaasRequest? request = null)
        {
            return await PostAsync<PaymentLinkResponse>($"/paymentLinks/{id}/restore", request);
        }

        /// <summary>
        /// Recupera uma imagem específica de um link de pagamento.
        /// </summary>
        public async Task<PaymentLinkImageResponse> GetPaymentLinkImage(string paymentLinkId, string imageId, BaseAsaasRequest? request = null)
        {
            return await GetAsync<PaymentLinkImageResponse>($"/paymentLinks/{paymentLinkId}/images/{imageId}", request);
        }

        /// <summary>
        /// Define uma imagem como principal em um link de pagamento.
        /// </summary>
        public async Task<PaymentLinkImageResponse> SetPaymentLinkImageAsMain(string paymentLinkId, string imageId, BaseAsaasRequest? request = null)
        {
            return await PostAsync<PaymentLinkImageResponse>($"/paymentLinks/{paymentLinkId}/images/{imageId}/setAsMain", request);
        }
    }
}
