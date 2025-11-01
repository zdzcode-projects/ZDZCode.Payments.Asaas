namespace ZDZCode.Payments.Asaas.DTO.Pix.Response
{
    public class PixQrCodeResponse
    {
        public string EncodedImage { get; set; }
        public string Payload { get; set; }
        public bool Success { get; set; }
        public string ExpirationDate { get; set; }
    }
}
