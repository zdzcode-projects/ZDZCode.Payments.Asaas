namespace ZDZCode.Payments.Asaas.DTO.Pix.Request
{
    public class PixQrCodeStaticRequest : BaseAsaasRequest
    {
        public string AddressKey { get; set; }
        public string Description { get; set; }
        public double? Value { get; set; }
        public string Format { get; set; }
        public int? ExpirationSeconds { get; set; }
        public bool? AllowsMultiplePayments { get; set; }
    }
}
