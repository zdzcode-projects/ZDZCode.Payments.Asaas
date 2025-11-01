namespace ZDZCode.Payments.Asaas.DTO.PaymentLink.Request
{
    public class PaymentLinkImageRequest : BaseAsaasRequest
    {
        public string Image { get; set; }
        public bool? Main { get; set; }
    }
}
