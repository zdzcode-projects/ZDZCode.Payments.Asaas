namespace ZDZCode.Payments.Asaas.DTO.Pix.Response
{
    public class PixQrCodeDecodeResponse
    {
        public string Payload { get; set; }
        public double Value { get; set; }
        public string TransactionReceiptUrl { get; set; }
        public string CanBePaid { get; set; }
    }
}
