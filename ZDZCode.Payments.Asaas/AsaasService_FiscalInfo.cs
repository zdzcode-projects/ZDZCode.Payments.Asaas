using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.DTO.FiscalInfo.Request;
using ZDZCode.Payments.Asaas.DTO.FiscalInfo.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a informações fiscais.
    /// Documentação: https://docs.asaas.com/reference/informacoes-fiscais
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Recupera as informações fiscais da conta.
        /// </summary>
        public async Task<FiscalInfoResponse> GetFiscalInfo(BaseAsaasRequest request = null)
        {
            return await GetAsync<FiscalInfoResponse>("/fiscalInfo", request);
        }

        /// <summary>
        /// Atualiza as informações fiscais da conta.
        /// </summary>
        public async Task<FiscalInfoResponse> UpdateFiscalInfo(FiscalInfoRequest request)
        {
            return await PostAsync<FiscalInfoResponse>("/fiscalInfo", request);
        }
    }
}
