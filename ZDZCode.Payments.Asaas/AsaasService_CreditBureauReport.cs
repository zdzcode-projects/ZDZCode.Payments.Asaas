using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.CreditBureauReport.Request;
using ZDZCode.Payments.Asaas.DTO.CreditBureauReport.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Solicita uma consulta ao bureau de crédito.
        /// </summary>
        public async Task<CreditBureauReportResponse> RequestCreditBureauReport(CreditBureauReportRequest request)
        {
            return await PostAsync<CreditBureauReportResponse>("/creditBureauReport", request);
        }

        /// <summary>
        /// Lista as consultas ao bureau de crédito.
        /// </summary>
        public async Task<ListPageResponse<CreditBureauReportResponse>> ListCreditBureauReports(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<CreditBureauReportResponse>>("/creditBureauReport", request);
        }

        /// <summary>
        /// Recupera uma consulta ao bureau de crédito pelo identificador.
        /// </summary>
        public async Task<CreditBureauReportResponse> GetCreditBureauReportById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<CreditBureauReportResponse>($"/creditBureauReport/{id}", request);
        }
    }
}
