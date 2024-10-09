using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.DTO.Customer.Request;
using ZDZCode.Payments.Asaas.DTO.Customer.Response;
using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        public async Task<CustomerResponse> CreateNewCustomer(CustomerRequest request)
        {
            return await PostAsync<CustomerResponse>("/customers", request);
        }

        public async Task<ListCustomersResponse> GetListCustomers(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListCustomersResponse>("/customers/", request);
        }

        public async Task<CustomerResponse> GetRetrieveASingleCustomer(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<CustomerResponse>($"/customers/{id}", request);
        }

        public async Task<CustomerResponse> UpdateExistingCustomer(string id, CustomerRequest request)
        {
            return await PutAsync<CustomerResponse>($"/customers/{id}", request);
        }

        public async Task<RetrieveNotificationsFromACustomerResponse> GetRetrieveNotificationsFromACustomer(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<RetrieveNotificationsFromACustomerResponse>($"/customers/{id}/notifications", request);
        }

        public async Task<DeleteCustomerResponse> RemoveCustomer(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<DeleteCustomerResponse>($"/customers/{id}", request);
        }

        public async Task<CustomerResponse>RestoreRemovedCustomer(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<CustomerResponse>($"/customers/{id}/restore", request);
        }
    }
}
