using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DataListResponse;
using ZDZCode.Payments.Asaas.DTO.Payment.Request;
using ZDZCode.Payments.Asaas.DTO.Payment.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a cobranças (payments).
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria uma nova cobrança.
        /// Documentação: https://docs.asaas.com/reference/criar-nova-cobranca
        /// </summary>
        /// <param name="request">Dados da cobrança a ser criada.</param>
        /// <returns>Resposta contendo os dados da cobrança criada.</returns>
        public async Task<CreateNewPaymentResponse> CreateNewPayment(CreateNewPaymentRequest request)
        {
            return await PostAsync<CreateNewPaymentResponse>("/payments", request);
        }

        /// <summary>
        /// Cria uma nova cobrança com dados resumidos (lean endpoint).
        /// Documentação: https://docs.asaas.com/reference/criar-cobranca-com-dados-resumidos
        /// </summary>
        /// <param name="request">Dados da cobrança a ser criada.</param>
        /// <returns>Resposta contendo os dados resumidos da cobrança criada.</returns>
        public async Task<CreateNewPaymentWithSummaryDataResponse> CreateNewPaymentWithSummaryData(CreateNewPaymentRequest request)
        {
            return await PostAsync<CreateNewPaymentWithSummaryDataResponse>("/lean/payments", request);
        }

        /// <summary>
        /// Lista todas as cobranças.
        /// Documentação: https://docs.asaas.com/reference/listar-cobrancas
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de cobranças.</returns>
        public async Task<ListPageResponse<ListPaymentsResponse>> GetListPayments(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<ListPaymentsResponse>>("/payments", request);
        }

        /// <summary>
        /// Lista todas as cobranças com dados resumidos (lean endpoint).
        /// Documentação: https://docs.asaas.com/reference/listar-cobrancas-com-dados-resumidos
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de cobranças com dados resumidos.</returns>
        public async Task<ListPageResponse<DataListPaymentsWithSummaryData>> GetListPaymentsWithSummaryData(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<DataListPaymentsWithSummaryData>>("/lean/payments", request);
        }

        /// <summary>
        /// Recupera uma cobrança pelo identificador.
        /// Documentação: https://docs.asaas.com/reference/recuperar-uma-unica-cobranca
        /// </summary>
        /// <param name="id">ID da cobrança.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Dados da cobrança.</returns>
        public async Task<CreateNewPaymentResponse> GetPaymentById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<CreateNewPaymentResponse>($"/payments/{id}", request);
        }

        /// <summary>
        /// Atualiza uma cobrança existente.
        /// Documentação: https://docs.asaas.com/reference/atualizar-cobranca-existente
        /// </summary>
        /// <param name="id">ID da cobrança a ser atualizada.</param>
        /// <param name="request">Dados atualizados da cobrança.</param>
        /// <returns>Resposta contendo os dados da cobrança atualizada.</returns>
        public async Task<CreateNewPaymentResponse> UpdatePayment(string id, CreateNewPaymentRequest request)
        {
            return await PostAsync<CreateNewPaymentResponse>($"/payments/{id}", request);
        }

        /// <summary>
        /// Remove uma cobrança.
        /// Documentação: https://docs.asaas.com/reference/remover-cobranca
        /// </summary>
        /// <param name="id">ID da cobrança a ser removida.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta da operação de remoção.</returns>
        public async Task<ValueResponse> DeletePayment(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<ValueResponse>($"/payments/{id}", request);
        }

        /// <summary>
        /// Restaura uma cobrança removida.
        /// Documentação: https://docs.asaas.com/reference/restaurar-cobranca
        /// </summary>
        /// <param name="id">ID da cobrança a ser restaurada.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta contendo os dados da cobrança restaurada.</returns>
        public async Task<CreateNewPaymentResponse> RestorePayment(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<CreateNewPaymentResponse>($"/payments/{id}/restore", request);
        }

        /// <summary>
        /// Confirma o recebimento em dinheiro de uma cobrança.
        /// Documentação: https://docs.asaas.com/reference/receber-em-dinheiro
        /// </summary>
        /// <param name="id">ID da cobrança.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta contendo os dados da cobrança atualizada.</returns>
        public async Task<CreateNewPaymentResponse> ReceivePaymentInCash(string id, CreateNewPaymentRequest request = null)
        {
            return await PostAsync<CreateNewPaymentResponse>($"/payments/{id}/receiveInCash", request);
        }

        /// <summary>
        /// Desfaz o recebimento em dinheiro de uma cobrança.
        /// Documentação: https://docs.asaas.com/reference/desfazer-recebimento-em-dinheiro
        /// </summary>
        /// <param name="id">ID da cobrança.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta contendo os dados da cobrança atualizada.</returns>
        public async Task<CreateNewPaymentResponse> UndoReceivedInCash(string id, BaseAsaasRequest request = null)
        {
            return await PostAsync<CreateNewPaymentResponse>($"/payments/{id}/undoReceivedInCash", request);
        }

        /// <summary>
        /// Simula uma cobrança para testes.
        /// Documentação: https://docs.asaas.com/reference/simular-cobranca
        /// </summary>
        /// <param name="request">Dados da cobrança a ser simulada.</param>
        /// <returns>Resposta contendo os dados da cobrança simulada.</returns>
        public async Task<CreateNewPaymentResponse> SimulatePayment(CreateNewPaymentRequest request)
        {
            return await PostAsync<CreateNewPaymentResponse>("/payments/simulate", request);
        }

    }
}
