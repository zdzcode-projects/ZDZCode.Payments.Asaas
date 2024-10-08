using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.DTO.Payment.Request;
using ZDZCode.Payments.Asaas.DTO.Payment.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {       
        public async Task<CreateNewPaymentResponse> CreateNewPayment(CreateNewPaymentRequest request)
        {
            return await PostAsync<CreateNewPaymentResponse>("/payments", request);
        }
    }
}
