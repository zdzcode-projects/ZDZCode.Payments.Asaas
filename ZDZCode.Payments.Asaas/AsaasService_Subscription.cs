using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Subscription.Request;
using ZDZCode.Payments.Asaas.DTO.Subscription.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria uma nova assinatura.
        /// </summary>
        public async Task<SubscriptionResponse> CreateSubscription(SubscriptionRequest request)
        {
            return await PostAsync<SubscriptionResponse>("/subscriptions", request);
        }

        /// <summary>
        /// Lista as assinaturas existentes.
        /// </summary>
        public async Task<ListPageResponse<SubscriptionResponse>> ListSubscriptions(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<SubscriptionResponse>>("/subscriptions", request);
        }

        /// <summary>
        /// Recupera uma assinatura pelo identificador.
        /// </summary>
        public async Task<SubscriptionResponse> GetSubscriptionById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<SubscriptionResponse>($"/subscriptions/{id}", request);
        }

        /// <summary>
        /// Atualiza uma assinatura existente.
        /// </summary>
        public async Task<SubscriptionResponse> UpdateSubscription(string id, SubscriptionRequest request)
        {
            return await PostAsync<SubscriptionResponse>($"/subscriptions/{id}", request);
        }

        /// <summary>
        /// Cancela uma assinatura existente.
        /// </summary>
        public async Task<ValueResponse> DeleteSubscription(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<ValueResponse>($"/subscriptions/{id}", request);
        }
    }
}
