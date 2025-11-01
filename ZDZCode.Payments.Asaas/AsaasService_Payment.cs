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

        /// <summary>
        /// Recupera uma cobrança pelo identificador.
        /// </summary>
        public async Task<CreateNewPaymentResponse> GetPaymentById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<CreateNewPaymentResponse>($"/payments/{id}", request);
        }

        /// <summary>
        /// Atualiza uma cobrança existente.
        /// </summary>
        public async Task<CreateNewPaymentResponse> UpdatePayment(string id, CreateNewPaymentRequest request)
        {
            return await PostAsync<CreateNewPaymentResponse>($"/payments/{id}", request);
        }

        /// <summary>
        /// Remove uma cobrança.
        /// </summary>
        public async Task<ValueResponse> DeletePayment(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<ValueResponse>($"/payments/{id}", request);
        }

        /// <summary>
        /// Restaura uma cobrança removida.
        /// </summary>
        public async Task<CreateNewPaymentResponse> RestorePayment(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<CreateNewPaymentResponse>($"/payments/{id}/restore", request);
        }

        /// <summary>
        /// Confirma o recebimento em dinheiro de uma cobrança.
        /// </summary>
        public async Task<CreateNewPaymentResponse> ReceivePaymentInCash(string id, CreateNewPaymentRequest request = null)
        {
            return await PostAsync<CreateNewPaymentResponse>($"/payments/{id}/receiveInCash", request);
        }

        /// <summary>
        /// Desfaz o recebimento em dinheiro de uma cobrança.
        /// </summary>
        public async Task<CreateNewPaymentResponse> UndoReceivedInCash(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<CreateNewPaymentResponse>($"/payments/{id}/undoReceivedInCash", request);
        }

        /// <summary>
        /// Simula uma cobrança.
        /// </summary>
        public async Task<CreateNewPaymentResponse> SimulatePayment(CreateNewPaymentRequest request)
        {
            return await PostAsync<CreateNewPaymentResponse>("/payments/simulate", request);
        }

    }
}
