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


        public async Task<RetrieveAsaasAccountNumberResponse> GetRetrieveAssasAccountNumber(BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrieveAsaasAccountNumberResponse>("/myAccount/commercialInfo", request);
        }

        public async Task<RetrieveBusinessDataResponse> GetRetrieveBusinessDataResponse(BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrieveBusinessDataResponse>("/myAccount/commercialInfo/", request);
        }

        public async Task<RetrievePersonalizationSettingsResponse> GetRetrievePersonalizationSettingsResponse(BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrievePersonalizationSettingsResponse>("/myAccount/paymentCheckoutConfig/", request);
        }

        public async Task<CheckAccountRegistrationStatusResponse> GetCheckAccountRegistrationStatus(BaseAsaasRequest request = null)
        {
            return await GetAsync<CheckAccountRegistrationStatusResponse>("/myAccount/status/", request);
        }

        public async Task<MyAccountAccountNumberResponse> GetMyAccountAccountNumber(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountAccountNumberResponse>("/myAccount/accountNumber", request);
        }
    }
}
