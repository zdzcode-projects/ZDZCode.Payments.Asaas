using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Invoice.Request;
using ZDZCode.Payments.Asaas.DTO.Invoice.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Agenda a emissão de uma nota fiscal de serviço.
        /// </summary>
        public async Task<InvoiceResponse> ScheduleInvoice(InvoiceRequest request)
        {
            return await PostAsync<InvoiceResponse>("/invoices", request);
        }

        /// <summary>
        /// Lista as notas fiscais.
        /// </summary>
        public async Task<ListPageResponse<InvoiceResponse>> ListInvoices(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<InvoiceResponse>>("/invoices", request);
        }

        /// <summary>
        /// Recupera uma nota fiscal pelo identificador.
        /// </summary>
        public async Task<InvoiceResponse> GetInvoiceById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<InvoiceResponse>($"/invoices/{id}", request);
        }

        /// <summary>
        /// Cancela uma nota fiscal.
        /// </summary>
        public async Task<InvoiceResponse> CancelInvoice(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<InvoiceResponse>($"/invoices/{id}/cancel", request);
        }

        /// <summary>
        /// Atualiza uma nota fiscal.
        /// </summary>
        public async Task<InvoiceResponse> UpdateInvoice(string id, InvoiceRequest request)
        {
            return await PutAsync<InvoiceResponse>($"/invoices/{id}", request);
        }
    }
}
