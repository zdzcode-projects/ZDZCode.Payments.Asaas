using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.DTO.CreditCard.Request;
using ZDZCode.Payments.Asaas.DTO.CreditCard.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a cartão de crédito.
    /// Documentação: https://docs.asaas.com/reference/cartao-credito
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Tokeniza um cartão de crédito para uso futuro.
        /// </summary>
        public async Task<CreditCardTokenResponse> TokenizeCreditCard(CreditCardTokenRequest request)
        {
            return await PostAsync<CreditCardTokenResponse>("/creditCard/tokenize", request);
        }
    }
}
