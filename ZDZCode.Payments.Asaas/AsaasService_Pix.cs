using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Pix.Request;
using ZDZCode.Payments.Asaas.DTO.Pix.Response;
using ZDZCode.Payments.Asaas.DTO.PixTransaction.Response;

namespace ZDZCode.Payments.Asaas
{
    /// <summary>
    /// Serviço parcial para operações relacionadas ao PIX.
    /// </summary>
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria uma nova chave PIX.
        /// Documentação: https://docs.asaas.com/reference/criar-chave-pix
        /// </summary>
        /// <param name="request">Dados da chave PIX a ser criada.</param>
        /// <returns>Resposta contendo os dados da chave PIX criada.</returns>
        public async Task<PixKeyResponse> CreatePixKey(PixKeyRequest request)
        {
            return await PostAsync<PixKeyResponse>("/pix/addressKeys", request);
        }

        /// <summary>
        /// Lista as chaves PIX cadastradas.
        /// Documentação: https://docs.asaas.com/reference/listar-chaves-pix
        /// </summary>
        /// <param name="request">Parâmetros opcionais de filtro e paginação.</param>
        /// <returns>Lista paginada de chaves PIX.</returns>
        public async Task<ListPageResponse<PixKeyResponse>> ListPixKeys(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<PixKeyResponse>>("/pix/addressKeys", request);
        }

        /// <summary>
        /// Remove uma chave PIX.
        /// Documentação: https://docs.asaas.com/reference/remover-chave-pix
        /// </summary>
        /// <param name="id">ID da chave PIX a ser removida.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Resposta da operação de remoção.</returns>
        public async Task<ValueResponse> DeletePixKey(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<ValueResponse>($"/pix/addressKeys/{id}", request);
        }

        /// <summary>
        /// Recupera o QR Code PIX de um pagamento.
        /// Documentação: https://docs.asaas.com/reference/recuperar-qr-code-pix
        /// </summary>
        /// <param name="paymentId">ID do pagamento.</param>
        /// <param name="request">Parâmetros opcionais.</param>
        /// <returns>Dados do QR Code PIX.</returns>
        public async Task<PixQrCodeResponse> GetPixQrCode(string paymentId, BaseAsaasRequest request = null)
        {
            return await GetAsync<PixQrCodeResponse>($"/payments/{paymentId}/pixQrCode", request);
        }

        /// <summary>
        /// Cria um QR Code PIX estático.
        /// Documentação: https://docs.asaas.com/reference/criar-qr-code-estatico
        /// </summary>
        /// <param name="request">Dados do QR Code estático a ser criado.</param>
        /// <returns>Resposta contendo os dados do QR Code criado.</returns>
        public async Task<PixQrCodeResponse> CreateStaticPixQrCode(PixQrCodeStaticRequest request)
        {
            return await PostAsync<PixQrCodeResponse>("/pix/qrCodes/static", request);
        }

        /// <summary>
        /// Decodifica um QR Code PIX.
        /// Documentação: https://docs.asaas.com/reference/decodificar-qr-code-pix
        /// </summary>
        /// <param name="request">Dados do QR Code a ser decodificado.</param>
        /// <returns>Dados decodificados do QR Code.</returns>
        public async Task<PixQrCodeDecodeResponse> DecodePixQrCode(PixQrCodeDecodeRequest request)
        {
            return await PostAsync<PixQrCodeDecodeResponse>("/pix/qrCodes/decode", request);
        }

        /// <summary>
        /// Realiza um pagamento PIX via QR Code.
        /// Documentação: https://docs.asaas.com/reference/pagar-com-qr-code-pix
        /// </summary>
        /// <param name="request">Dados do pagamento a ser realizado.</param>
        /// <returns>Resposta contendo os dados da transação PIX.</returns>
        public async Task<PixTransactionResponse> PayWithPixQrCode(PixQrCodePayRequest request)
        {
            return await PostAsync<PixTransactionResponse>("/pix/qrCodes/pay", request);
        }
    }
}
