using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Customer.Request;
using ZDZCode.Payments.Asaas.DTO.Customer.Response;
using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a clientes (customers).
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria um novo cliente.
        /// Documentação: https://docs.asaas.com/reference/criar-novo-cliente
        /// </summary>
        /// <param name="request">Dados do cliente a ser criado.</param>
        /// <returns>Resposta contendo os dados do cliente criado.</returns>
        public async Task<CustomerResponse> CreateNewCustomer(CustomerRequest request)
        {
            return await PostAsync<CustomerResponse>("/customers", request);
        }

        /// <summary>
        /// Lista todos os clientes.
        /// Documentação: https://docs.asaas.com/reference/listar-clientes
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de clientes.</returns>
        public async Task<ListPageResponse<ListCustomersResponse>> GetListCustomers(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<ListCustomersResponse>>("/customers/", request);
        }

        /// <summary>
        /// Recupera um cliente específico pelo ID.
        /// Documentação: https://docs.asaas.com/reference/recuperar-um-unico-cliente
        /// </summary>
        /// <param name="id">ID do cliente.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Dados do cliente.</returns>
        public async Task<CustomerResponse> GetRetrieveASingleCustomer(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<CustomerResponse>($"/customers/{id}", request);
        }

        /// <summary>
        /// Atualiza um cliente existente.
        /// Documentação: https://docs.asaas.com/reference/atualizar-cliente-existente
        /// </summary>
        /// <param name="id">ID do cliente a ser atualizado.</param>
        /// <param name="request">Dados atualizados do cliente.</param>
        /// <returns>Resposta contendo os dados do cliente atualizado.</returns>
        public async Task<CustomerResponse> UpdateExistingCustomer(string id, CustomerRequest request)
        {
            return await PutAsync<CustomerResponse>($"/customers/{id}", request);
        }

        /// <summary>
        /// Recupera as notificações de um cliente.
        /// Documentação: https://docs.asaas.com/reference/recuperar-notificacoes-de-um-cliente
        /// </summary>
        /// <param name="id">ID do cliente.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Notificações do cliente.</returns>
        public async Task<RetrieveNotificationsFromACustomerResponse> GetRetrieveNotificationsFromACustomer(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrieveNotificationsFromACustomerResponse>($"/customers/{id}/notifications", request);
        }

        /// <summary>
        /// Remove um cliente.
        /// Documentação: https://docs.asaas.com/reference/remover-cliente
        /// </summary>
        /// <param name="id">ID do cliente a ser removido.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta da operação de remoção.</returns>
        public async Task<DeleteCustomerResponse> RemoveCustomer(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<DeleteCustomerResponse>($"/customers/{id}", request);
        }

        /// <summary>
        /// Restaura um cliente removido.
        /// Documentação: https://docs.asaas.com/reference/restaurar-cliente-removido
        /// </summary>
        /// <param name="id">ID do cliente a ser restaurado.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta contendo os dados do cliente restaurado.</returns>
        public async Task<CustomerResponse>RestoreRemovedCustomer(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<CustomerResponse>($"/customers/{id}/restore", request);
        }
    }
}
