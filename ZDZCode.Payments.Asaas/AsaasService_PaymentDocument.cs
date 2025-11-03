using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.PaymentDocument.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a documentos de cobrança.
    /// Documentação: https://docs.asaas.com/reference/documentos-cobranca
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Lista os documentos disponíveis de um pagamento.
        /// </summary>
        public async Task<ListPageResponse<PaymentDocumentResponse>> ListPaymentDocuments(string paymentId, BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<PaymentDocumentResponse>>($"/payments/{paymentId}/documents", request);
        }
    }
}
