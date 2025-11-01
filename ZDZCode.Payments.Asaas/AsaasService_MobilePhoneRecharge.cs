using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.MobilePhoneRecharge.Request;
using ZDZCode.Payments.Asaas.DTO.MobilePhoneRecharge.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Solicita uma recarga de celular.
        /// </summary>
        public async Task<MobilePhoneRechargeResponse> RequestMobilePhoneRecharge(MobilePhoneRechargeRequest request)
        {
            return await PostAsync<MobilePhoneRechargeResponse>("/mobilePhoneRecharges", request);
        }

        /// <summary>
        /// Lista as recargas de celular solicitadas.
        /// </summary>
        public async Task<ListPageResponse<MobilePhoneRechargeResponse>> ListMobilePhoneRecharges(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<MobilePhoneRechargeResponse>>("/mobilePhoneRecharges", request);
        }

        /// <summary>
        /// Recupera uma recarga de celular pelo identificador.
        /// </summary>
        public async Task<MobilePhoneRechargeResponse> GetMobilePhoneRechargeById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<MobilePhoneRechargeResponse>($"/mobilePhoneRecharges/{id}", request);
        }
    }
}
