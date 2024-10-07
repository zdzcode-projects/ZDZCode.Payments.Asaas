using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.DTO.Customer.Request;
using ZDZCode.Payments.Asaas.DTO.Customer.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        public async Task<CustomerResponse> CreateNewCustomer(CustomerRequest request)
        {
            return await PostAsync<CustomerResponse>("/customers", request);
        }
    }
}
