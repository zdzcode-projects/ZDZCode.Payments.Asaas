using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.PixTransaction.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Lista as transações PIX.
        /// </summary>
        public async Task<ListPageResponse<PixTransactionResponse>> ListPixTransactions(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<PixTransactionResponse>>("/pix/transactions", request);
        }

        /// <summary>
        /// Recupera uma transação PIX pelo identificador.
        /// </summary>
        public async Task<PixTransactionResponse> GetPixTransactionById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<PixTransactionResponse>($"/pix/transactions/{id}", request);
        }
    }
}
