using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Accountinfo.Request;
 
using ZDZCode.Payments.Asaas.DTO.Accountinfo.Response;
using ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        public async Task<MyAccountCommercialInfoResponse> GetMyAccountCommercialInfo(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountCommercialInfoResponse>("/myAccount/commercialInfo", request);
        }       


        public async Task<RetrievePersonalizationSettingsResponse> GetRetrievePersonalizationSettingsResponse(BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrievePersonalizationSettingsResponse>("/myAccount/paymentCheckoutConfig/", request);
        }

        public async Task<RetrieveAsaasAccountNumberResponse> GetRetrieveAssasAccountNumber(BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrieveAsaasAccountNumberResponse>("/myAccount/accountNumber", request);
        }

        public async Task<RetrieveAccountFeesResponse> GetRetrieveAccountFeesResponse(BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrieveAccountFeesResponse>("/myAccount/fees/", request);
        } 

        public async Task<CheckAccountRegistrationStatusResponse> GetCheckAccountRegistrationStatus(BaseAsaasRequest request = null)
        {
            return await GetAsync<CheckAccountRegistrationStatusResponse>("/myAccount/status/", request);
        }
        public async Task<ListPageResponse<RetrieveWalletIdResponse>> GetRetrieveWalletIdResponse(BaseAsaasRequest request = null)
          {
            return await GetAsync<ListPageResponse<RetrieveWalletIdResponse>>("/wallets/", request);
        }

        public async Task<MyAccountAccountNumberResponse> GetMyAccountAccountNumber(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountAccountNumberResponse>("/myAccount/accountNumber", request);
        }

        public async Task<MyAccountPaymentCheckoutConfigResponse> GetMyAccountPaymentCheckoutConfig(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountPaymentCheckoutConfigResponse>("/myAccount/paymentCheckoutConfig", request);
        }

        public async Task<MyAccountFeesResponse> GetMyAccountFees(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountFeesResponse>("/myAccount/fees", request);

        }

        public async Task<UpdateBusinessDataResponse> UpdateBusinessDataResponse(UpdateBusinessDataRequest request)
        {
            return await PostAsync<UpdateBusinessDataResponse>("/myAccount/commercialInfo/", request);
        }

        /// <summary>
        /// Recupera informações da conta Asaas.
        /// </summary>
        public async Task<MyAccountCommercialInfoResponse> GetMyAccount(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountCommercialInfoResponse>("/myAccount/", request);
        }

        /// <summary>
        /// Atualiza a configuração do checkout de pagamento.
        /// </summary>
        public async Task<PaymentCheckoutConfigResponse> UpdatePaymentCheckoutConfig(PaymentCheckoutConfigRequest request)
        {
            return await PostAsync<PaymentCheckoutConfigResponse>("/myAccount/paymentCheckoutConfig/", request);
        }
 
    }
}
