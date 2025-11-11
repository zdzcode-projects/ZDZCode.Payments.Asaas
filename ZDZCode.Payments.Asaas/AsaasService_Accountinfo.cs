using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Accountinfo.Request;
 
using ZDZCode.Payments.Asaas.DTO.Accountinfo.Response;
using ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a informações da conta.
    /// Documentação: https://docs.asaas.com/reference/informacoes-conta
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Recupera as informações comerciais da conta.
        /// Documentação: https://docs.asaas.com/reference/recuperar-informacoes-comerciais
        /// </summary>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Informações comerciais da conta.</returns>
        public async Task<MyAccountCommercialInfoResponse> GetMyAccountCommercialInfo(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountCommercialInfoResponse>("/myAccount/commercialInfo", request);
        }       

        /// <summary>
        /// Recupera as configurações de personalização do checkout de pagamento.
        /// Documentação: https://docs.asaas.com/reference/recuperar-configuracoes-personalizacao
        /// </summary>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Configurações de personalização.</returns>
        public async Task<RetrievePersonalizationSettingsResponse> GetRetrievePersonalizationSettingsResponse(BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrievePersonalizationSettingsResponse>("/myAccount/paymentCheckoutConfig/", request);
        }

        /// <summary>
        /// Recupera o número da conta Asaas.
        /// Documentação: https://docs.asaas.com/reference/recuperar-numero-conta
        /// </summary>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Número da conta.</returns>
        public async Task<RetrieveAsaasAccountNumberResponse> GetRetrieveAssasAccountNumber(BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrieveAsaasAccountNumberResponse>("/myAccount/accountNumber", request);
        }

        /// <summary>
        /// Recupera as taxas configuradas para a conta.
        /// Documentação: https://docs.asaas.com/reference/recuperar-taxas-conta
        /// </summary>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Taxas da conta.</returns>
        public async Task<RetrieveAccountFeesResponse> GetRetrieveAccountFeesResponse(BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrieveAccountFeesResponse>("/myAccount/fees/", request);
        } 

        /// <summary>
        /// Verifica o status de cadastro da conta.
        /// Documentação: https://docs.asaas.com/reference/verificar-status-cadastro
        /// </summary>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Status de cadastro da conta.</returns>
        public async Task<CheckAccountRegistrationStatusResponse> GetCheckAccountRegistrationStatus(BaseAsaasRequest request = null)
        {
            return await GetAsync<CheckAccountRegistrationStatusResponse>("/myAccount/status/", request);
        }

        /// <summary>
        /// Lista as carteiras (wallets) da conta.
        /// Documentação: https://docs.asaas.com/reference/listar-carteiras
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de carteiras.</returns>
        public async Task<ListPageResponse<RetrieveWalletIdResponse>> GetRetrieveWalletIdResponse(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<RetrieveWalletIdResponse>>("/wallets/", request);
        }

        /// <summary>
        /// Recupera o número da conta (método alternativo).
        /// Documentação: https://docs.asaas.com/reference/recuperar-numero-conta
        /// </summary>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Número da conta.</returns>
        public async Task<MyAccountAccountNumberResponse> GetMyAccountAccountNumber(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountAccountNumberResponse>("/myAccount/accountNumber", request);
        }

        /// <summary>
        /// Recupera as configurações do checkout de pagamento.
        /// Documentação: https://docs.asaas.com/reference/recuperar-configuracoes-checkout
        /// </summary>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Configurações do checkout.</returns>
        public async Task<MyAccountPaymentCheckoutConfigResponse> GetMyAccountPaymentCheckoutConfig(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountPaymentCheckoutConfigResponse>("/myAccount/paymentCheckoutConfig", request);
        }

        /// <summary>
        /// Recupera as taxas da conta.
        /// Documentação: https://docs.asaas.com/reference/recuperar-taxas
        /// </summary>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Taxas da conta.</returns>
        public async Task<MyAccountFeesResponse> GetMyAccountFees(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountFeesResponse>("/myAccount/fees", request);

        }

        /// <summary>
        /// Atualiza os dados comerciais da conta.
        /// Documentação: https://docs.asaas.com/reference/atualizar-dados-comerciais
        /// </summary>
        /// <param name="request">Dados comerciais atualizados.</param>
        /// <returns>Resposta contendo os dados comerciais atualizados.</returns>
        public async Task<UpdateBusinessDataResponse> UpdateBusinessDataResponse(UpdateBusinessDataRequest request)
        {
            return await PostAsync<UpdateBusinessDataResponse>("/myAccount/commercialInfo/", request);
        }

        /// <summary>
        /// Recupera informações gerais da conta Asaas.
        /// Documentação: https://docs.asaas.com/reference/recuperar-informacoes-conta
        /// </summary>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Informações da conta.</returns>
        public async Task<MyAccountCommercialInfoResponse> GetMyAccount(BaseAsaasRequest request = null)
        {
            return await GetAsync<MyAccountCommercialInfoResponse>("/myAccount/", request);
        }

        /// <summary>
        /// Atualiza a configuração do checkout de pagamento.
        /// Documentação: https://docs.asaas.com/reference/atualizar-configuracao-checkout
        /// </summary>
        /// <param name="request">Configurações do checkout a serem atualizadas.</param>
        /// <returns>Resposta contendo as configurações atualizadas.</returns>
        public async Task<PaymentCheckoutConfigResponse> UpdatePaymentCheckoutConfig(PaymentCheckoutConfigRequest request)
        {
            return await PostAsync<PaymentCheckoutConfigResponse>("/myAccount/paymentCheckoutConfig/", request);
        }
 
    }
}
