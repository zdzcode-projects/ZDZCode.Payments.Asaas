using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.DTO.Accountinfo.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        public async Task<MyAccountCommercialInfoResponse> GetMyAccountCommercialInfo(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountCommercialInfoResponse>("/myAccount/commercialInfo", request);
        }
    }
}
