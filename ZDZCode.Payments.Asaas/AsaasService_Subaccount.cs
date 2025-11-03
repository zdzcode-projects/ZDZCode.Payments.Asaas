using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Subaccount.Request;
using ZDZCode.Payments.Asaas.DTO.Subaccount.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a subcontas.
    /// Documentação: https://docs.asaas.com/reference/subcontas
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria uma nova subconta.
        /// </summary>
        public async Task<SubaccountResponse> CreateSubaccount(SubaccountRequest request)
        {
            return await PostAsync<SubaccountResponse>("/subaccounts", request);
        }

        /// <summary>
        /// Lista as subcontas existentes.
        /// </summary>
        public async Task<ListPageResponse<SubaccountResponse>> ListSubaccounts(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<SubaccountResponse>>("/subaccounts", request);
        }

        /// <summary>
        /// Recupera uma subconta pelo identificador.
        /// </summary>
        public async Task<SubaccountResponse> GetSubaccountById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<SubaccountResponse>($"/subaccounts/{id}", request);
        }
    }
}
