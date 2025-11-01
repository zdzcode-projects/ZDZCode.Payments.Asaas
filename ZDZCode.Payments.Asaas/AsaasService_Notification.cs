using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Notification.Request;
using ZDZCode.Payments.Asaas.DTO.Notification.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Atualiza as notificações de um cliente.
        /// </summary>
        public async Task<NotificationResponse> UpdateCustomerNotifications(string customerId, NotificationRequest request)
        {
            return await PutAsync<NotificationResponse>($"/notifications/{customerId}", request);
        }

        /// <summary>
        /// Recupera as configurações de notificação de um cliente.
        /// </summary>
        public async Task<NotificationResponse> GetCustomerNotifications(string customerId, BaseAsaasRequest request = null)
        {
            return await GetAsync<NotificationResponse>($"/notifications/{customerId}", request);
        }
    }
}
