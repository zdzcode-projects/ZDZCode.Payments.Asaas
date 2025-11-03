using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Bill.Request;
using ZDZCode.Payments.Asaas.DTO.Bill.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a contas a pagar.
    /// Documentação: https://docs.asaas.com/reference/contas-pagar
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Agenda o pagamento de uma conta.
        /// </summary>
        public async Task<BillResponse> ScheduleBillPayment(BillRequest request)
        {
            return await PostAsync<BillResponse>("/bills", request);
        }

        /// <summary>
        /// Lista os pagamentos de contas.
        /// </summary>
        public async Task<ListPageResponse<BillResponse>> ListBills(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<BillResponse>>("/bills", request);
        }

        /// <summary>
        /// Recupera um pagamento de conta pelo identificador.
        /// </summary>
        public async Task<BillResponse> GetBillById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<BillResponse>($"/bills/{id}", request);
        }

        /// <summary>
        /// Cancela um pagamento de conta agendado.
        /// </summary>
        public async Task<ValueResponse> CancelBill(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<ValueResponse>($"/bills/{id}/cancel", request);
        }

        /// <summary>
        /// Simula um pagamento de conta.
        /// </summary>
        public async Task<BillResponse> SimulateBill(BillRequest request)
        {
            return await PostAsync<BillResponse>("/bill/simulate", request);
        }
    }
}
