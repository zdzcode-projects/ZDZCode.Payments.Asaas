using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.AccountDocument.Request;
using ZDZCode.Payments.Asaas.DTO.AccountDocument.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a documentos de conta.
    /// Documentação: https://docs.asaas.com/reference/documentos-conta
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Envia um documento da conta para validação.
        /// </summary>
        public async Task<AccountDocumentResponse> SendAccountDocument(AccountDocumentRequest request)
        {
            return await PostAsync<AccountDocumentResponse>("/myAccount/documents", request);
        }

        /// <summary>
        /// Lista os documentos da conta.
        /// </summary>
        public async Task<ListPageResponse<AccountDocumentResponse>> ListAccountDocuments(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<AccountDocumentResponse>>("/myAccount/documents", request);
        }

        /// <summary>
        /// Recupera um documento da conta pelo identificador.
        /// </summary>
        public async Task<AccountDocumentResponse> GetAccountDocumentById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<AccountDocumentResponse>($"/myAccount/documents/{id}", request);
        }
    }
}
