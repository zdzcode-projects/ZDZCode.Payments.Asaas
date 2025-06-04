using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Transfer.Request;
using ZDZCode.Payments.Asaas.DTO.Transfer.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria uma nova transferência.
        /// </summary>
        public async Task<TransferResponse> CreateTransfer(TransferRequest request)
        {
            return await PostAsync<TransferResponse>("/transfers", request);
        }

        /// <summary>
        /// Lista transferências existentes.
        /// </summary>
        public async Task<ListPageResponse<TransferResponse>> ListTransfers(BaseAsaasRequest? request = null)
        {
            return await GetAsync<ListPageResponse<TransferResponse>>("/transfers", request);
        }

        /// <summary>
        /// Recupera uma transferência pelo identificador.
        /// </summary>
        public async Task<TransferResponse> GetTransferById(string id, BaseAsaasRequest? request = null)
        {
            return await GetAsync<TransferResponse>($"/transfers/{id}", request);
        }
    }
}
