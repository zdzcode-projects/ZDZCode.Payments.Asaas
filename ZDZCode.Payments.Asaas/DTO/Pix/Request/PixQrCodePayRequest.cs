namespace ZDZCode.Payments.Asaas.DTO.Pix.Request
{
    public class PixQrCodePayRequest : BaseAsaasRequest
    {
        public string QrCode { get; set; }
        public double? Value { get; set; }
        public string Description { get; set; }
        public string ScheduleDate { get; set; }
    }
}
