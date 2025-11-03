using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Transfer.Request;
using ZDZCode.Payments.Asaas.DTO.Transfer.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas a transferências (transfers).
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria uma nova transferência.
        /// Documentação: https://docs.asaas.com/reference/criar-transferencia
        /// </summary>
        /// <param name="request">Dados da transferência a ser criada.</param>
        /// <returns>Resposta contendo os dados da transferência criada.</returns>
        public async Task<TransferResponse> CreateTransfer(TransferRequest request)
        {
            return await PostAsync<TransferResponse>("/transfers", request);
        }

        /// <summary>
        /// Lista transferências existentes.
        /// Documentação: https://docs.asaas.com/reference/listar-transferencias
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de transferências.</returns>
        public async Task<ListPageResponse<TransferResponse>> ListTransfers(BaseAsaasRequest? request = null)
        {
            return await GetAsync<ListPageResponse<TransferResponse>>("/transfers", request);
        }

        /// <summary>
        /// Recupera uma transferência pelo identificador.
        /// Documentação: https://docs.asaas.com/reference/recuperar-transferencia
        /// </summary>
        /// <param name="id">ID da transferência.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Dados da transferência.</returns>
        public async Task<TransferResponse> GetTransferById(string id, BaseAsaasRequest? request = null)
        {
            return await GetAsync<TransferResponse>($"/transfers/{id}", request);
        }
    }
}
