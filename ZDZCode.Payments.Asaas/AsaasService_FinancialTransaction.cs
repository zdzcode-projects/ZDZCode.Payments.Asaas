using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.FinancialTransaction.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a extrato financeiro.
    /// Documentação: https://docs.asaas.com/reference/extrato
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Lista as transações financeiras.
        /// </summary>
        public async Task<ListPageResponse<FinancialTransactionResponse>> ListFinancialTransactions(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<FinancialTransactionResponse>>("/financialTransactions", request);
        }

        /// <summary>
        /// Recupera uma transação financeira pelo identificador.
        /// </summary>
        public async Task<FinancialTransactionResponse> GetFinancialTransactionById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<FinancialTransactionResponse>($"/financialTransactions/{id}", request);
        }
    }
}
