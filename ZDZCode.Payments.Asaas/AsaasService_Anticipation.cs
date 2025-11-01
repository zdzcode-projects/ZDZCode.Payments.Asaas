using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Anticipation.Request;
using ZDZCode.Payments.Asaas.DTO.Anticipation.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Solicita uma antecipação de recebíveis.
        /// </summary>
        public async Task<AnticipationResponse> RequestAnticipation(AnticipationRequest request)
        {
            return await PostAsync<AnticipationResponse>("/anticipations", request);
        }

        /// <summary>
        /// Lista as antecipações existentes.
        /// </summary>
        public async Task<ListPageResponse<AnticipationResponse>> ListAnticipations(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<AnticipationResponse>>("/anticipations", request);
        }

        /// <summary>
        /// Recupera uma antecipação pelo identificador.
        /// </summary>
        public async Task<AnticipationResponse> GetAnticipationById(string id, BaseAsaasRequest request = null)
        {
            return await GetAsync<AnticipationResponse>($"/anticipations/{id}", request);
        }
    }
}
