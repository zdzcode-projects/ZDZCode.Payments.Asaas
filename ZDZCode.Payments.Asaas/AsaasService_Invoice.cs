using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Invoice.Request;
using ZDZCode.Payments.Asaas.DTO.Invoice.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a notas fiscais (invoices).
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Agenda a emissão de uma nota fiscal de serviço.
        /// Documentação: https://docs.asaas.com/reference/agendar-nota-fiscal
        /// </summary>
        /// <param name="request">Dados da nota fiscal a ser agendada.</param>
        /// <returns>Resposta contendo os dados da nota fiscal agendada.</returns>
        public async Task<InvoiceResponse> ScheduleInvoice(InvoiceRequest request)
        {
            return await PostAsync<InvoiceResponse>("/invoices", request);
        }

        /// <summary>
        /// Lista as notas fiscais.
        /// Documentação: https://docs.asaas.com/reference/listar-notas-fiscais
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de notas fiscais.</returns>
        public async Task<ListPageResponse<InvoiceResponse>> ListInvoices(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<InvoiceResponse>>("/invoices", request);
        }

        /// <summary>
        /// Recupera uma nota fiscal pelo identificador.
        /// Documentação: https://docs.asaas.com/reference/recuperar-nota-fiscal
        /// </summary>
        /// <param name="id">ID da nota fiscal.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Dados da nota fiscal.</returns>
        public async Task<InvoiceResponse> GetInvoiceById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<InvoiceResponse>($"/invoices/{id}", request);
        }

        /// <summary>
        /// Cancela uma nota fiscal.
        /// Documentação: https://docs.asaas.com/reference/cancelar-nota-fiscal
        /// </summary>
        /// <param name="id">ID da nota fiscal a ser cancelada.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta contendo os dados da nota fiscal cancelada.</returns>
        public async Task<InvoiceResponse> CancelInvoice(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<InvoiceResponse>($"/invoices/{id}/cancel", request);
        }

        /// <summary>
        /// Atualiza uma nota fiscal.
        /// Documentação: https://docs.asaas.com/reference/atualizar-nota-fiscal
        /// </summary>
        /// <param name="id">ID da nota fiscal a ser atualizada.</param>
        /// <param name="request">Dados atualizados da nota fiscal.</param>
        /// <returns>Resposta contendo os dados da nota fiscal atualizada.</returns>
        public async Task<InvoiceResponse> UpdateInvoice(string id, InvoiceRequest request)
        {
            return await PutAsync<InvoiceResponse>($"/invoices/{id}", request);
        }

        /// <summary>
        /// Autoriza uma nota fiscal.
        /// Documentação: https://docs.asaas.com/reference/autorizar-nota-fiscal
        /// </summary>
        /// <param name="id">ID da nota fiscal a ser autorizada.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta contendo os dados da nota fiscal autorizada.</returns>
        public async Task<InvoiceResponse> AuthorizeInvoice(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<InvoiceResponse>($"/invoices/{id}/authorize", request);
        }

        /// <summary>
        /// Lista os serviços municipais disponíveis para emissão de notas fiscais.
        /// Documentação: https://docs.asaas.com/reference/listar-servicos-municipais
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de serviços municipais.</returns>
        public async Task<ListPageResponse<MunicipalServiceResponse>> ListMunicipalServices(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<MunicipalServiceResponse>>("/fiscalInfo/services", request);
        }
    }
}
