using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DataListResponse;
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

        public async Task<CreateNewPaymentWithSummaryDataResponse> CreateNewPaymentWithSummaryData(CreateNewPaymentRequest request)
        {
            return await PostAsync<CreateNewPaymentWithSummaryDataResponse>("/lean/payments", request);
        }


        public async Task<ListPageResponse<ListPaymentsResponse>> GetListPayments(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<ListPaymentsResponse>>("/payments", request);
        }

        public async Task<ListPageResponse<DataListPaymentsWithSummaryData>> GetListPaymentsWithSummaryData(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<DataListPaymentsWithSummaryData>>("/lean/payments", request);
        }

    }
}
