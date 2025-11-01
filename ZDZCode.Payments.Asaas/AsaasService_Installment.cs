using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Installment.Request;
using ZDZCode.Payments.Asaas.DTO.Installment.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria um novo parcelamento.
        /// </summary>
        public async Task<InstallmentResponse> CreateInstallment(InstallmentRequest request)
        {
            return await PostAsync<InstallmentResponse>("/installments", request);
        }

        /// <summary>
        /// Lista os parcelamentos existentes.
        /// </summary>
        public async Task<ListPageResponse<InstallmentResponse>> ListInstallments(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<InstallmentResponse>>("/installments", request);
        }

        /// <summary>
        /// Recupera um parcelamento pelo identificador.
        /// </summary>
        public async Task<InstallmentResponse> GetInstallmentById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<InstallmentResponse>($"/installments/{id}", request);
        }

        /// <summary>
        /// Cancela um parcelamento existente.
        /// </summary>
        public async Task<ValueResponse> DeleteInstallment(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<ValueResponse>($"/installments/{id}", request);
        }

        /// <summary>
        /// Atualiza um parcelamento existente.
        /// </summary>
        public async Task<InstallmentResponse> UpdateInstallment(string id, InstallmentRequest request)
        {
            return await PutAsync<InstallmentResponse>($"/installments/{id}", request);
        }

        /// <summary>
        /// Lista os pagamentos de um parcelamento.
        /// </summary>
        public async Task<ListPageResponse<DTO.Payment.Response.CreateNewPaymentResponse>> ListInstallmentPayments(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<DTO.Payment.Response.CreateNewPaymentResponse>>($"/installments/{id}/payments", request);
        }

        /// <summary>
        /// Recupera o carnê de um parcelamento.
        /// </summary>
        public async Task<ValueResponse> GetInstallmentPaymentBook(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<ValueResponse>($"/installments/{id}/paymentBook", request);
        }

        /// <summary>
        /// Estorna um parcelamento.
        /// </summary>
        public async Task<ValueResponse> RefundInstallment(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<ValueResponse>($"/installments/{id}/refund", request);
        }
    }
}
