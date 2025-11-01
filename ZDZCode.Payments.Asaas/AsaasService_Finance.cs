using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.DTO.Finance.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Recupera o saldo atual da conta.
        /// </summary>
        public async Task<FinanceBalanceResponse> GetBalance(BaseAsaasRequest request = null)
        {
            return await GetAsync<FinanceBalanceResponse>("/finance/balance", request);
        }

        /// <summary>
        /// Recupera estatísticas financeiras da conta.
        /// </summary>
        public async Task<FinanceStatisticsResponse> GetFinanceStatistics(BaseAsaasRequest request = null)
        {
            return await GetAsync<FinanceStatisticsResponse>("/finance/getCurrentBalance", request);
        }

        /// <summary>
        /// Recupera estatísticas de pagamento.
        /// </summary>
        public async Task<FinancePaymentStatisticsResponse> GetPaymentStatistics(BaseAsaasRequest request = null)
        {
            return await GetAsync<FinancePaymentStatisticsResponse>("/finance/payment/statistics", request);
        }

        /// <summary>
        /// Recupera estatísticas de split de pagamentos.
        /// </summary>
        public async Task<FinanceSplitStatisticsResponse> GetSplitStatistics(BaseAsaasRequest request = null)
        {
            return await GetAsync<FinanceSplitStatisticsResponse>("/finance/split/statistics", request);
        }
    }
}
