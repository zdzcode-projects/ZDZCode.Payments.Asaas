using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Notification.Request;
using ZDZCode.Payments.Asaas.DTO.Notification.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a notificações (notifications).
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Atualiza as notificações de um cliente.
        /// Documentação: https://docs.asaas.com/reference/atualizar-notificacoes-existente
        /// </summary>
        /// <param name="customerId">ID do cliente.</param>
        /// <param name="request">Dados das notificações a serem atualizadas.</param>
        /// <returns>Resposta contendo os dados das notificações atualizadas.</returns>
        public async Task<NotificationResponse> UpdateCustomerNotifications(string customerId, NotificationRequest request)
        {
            return await PutAsync<NotificationResponse>($"/notifications/{customerId}", request);
        }

        /// <summary>
        /// Recupera as configurações de notificação de um cliente.
        /// Documentação: https://docs.asaas.com/reference/recuperar-configuracoes-notificacao
        /// </summary>
        /// <param name="customerId">ID do cliente.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Configurações de notificação do cliente.</returns>
        public async Task<NotificationResponse> GetCustomerNotifications(string customerId, BaseAsaasRequest request = null)
        {
            return await GetAsync<NotificationResponse>($"/notifications/{customerId}", request);
        }

        /// <summary>
        /// Atualiza as notificações de múltiplos clientes em lote.
        /// Documentação: https://docs.asaas.com/reference/atualizar-notificacoes-lote
        /// </summary>
        /// <param name="request">Dados das notificações em lote.</param>
        /// <returns>Lista de notificações atualizadas.</returns>
        public async Task<ListPageResponse<NotificationResponse>> UpdateNotificationsBatch(NotificationBatchRequest request)
        {
            return await PostAsync<ListPageResponse<NotificationResponse>>("/notifications/batch", request);
        }
    }
}
