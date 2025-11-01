using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.DTO.Pix.Request;
using ZDZCode.Payments.Asaas.DTO.Pix.Response;
using ZDZCode.Payments.Asaas.DTO.PixTransaction.Response;

namespace ZDZCode.Payments.Asaas
{
    public partial class AsaasService : HttpServiceBase
    {
        /// <summary>
        /// Cria uma nova chave PIX.
        /// </summary>
        public async Task<PixKeyResponse> CreatePixKey(PixKeyRequest request)
        {
            return await PostAsync<PixKeyResponse>("/pix/addressKeys", request);
        }

        /// <summary>
        /// Lista as chaves PIX cadastradas.
        /// </summary>
        public async Task<ListPageResponse<PixKeyResponse>> ListPixKeys(BaseAsaasRequest request = null)
        {
            return await GetAsync<ListPageResponse<PixKeyResponse>>("/pix/addressKeys", request);
        }

        /// <summary>
        /// Remove uma chave PIX.
        /// </summary>
        public async Task<ValueResponse> DeletePixKey(string id, BaseAsaasRequest request = null)
        {
            return await DeleteAsync<ValueResponse>($"/pix/addressKeys/{id}", request);
        }

        /// <summary>
        /// Recupera o QR Code PIX de um pagamento.
        /// </summary>
        public async Task<PixQrCodeResponse> GetPixQrCode(string paymentId, BaseAsaasRequest request = null)
        {
            return await GetAsync<PixQrCodeResponse>($"/payments/{paymentId}/pixQrCode", request);
        }

        /// <summary>
        /// Cria um QR Code PIX estático.
        /// </summary>
        public async Task<PixQrCodeResponse> CreateStaticPixQrCode(PixQrCodeStaticRequest request)
        {
            return await PostAsync<PixQrCodeResponse>("/pix/qrCodes/static", request);
        }

        /// <summary>
        /// Decodifica um QR Code PIX.
        /// </summary>
        public async Task<PixQrCodeDecodeResponse> DecodePixQrCode(PixQrCodeDecodeRequest request)
        {
            return await PostAsync<PixQrCodeDecodeResponse>("/pix/qrCodes/decode", request);
        }

        /// <summary>
        /// Realiza um pagamento PIX via QR Code.
        /// </summary>
        public async Task<PixTransactionResponse> PayWithPixQrCode(PixQrCodePayRequest request)
        {
            return await PostAsync<PixTransactionResponse>("/pix/qrCodes/pay", request);
        }
    }
}
