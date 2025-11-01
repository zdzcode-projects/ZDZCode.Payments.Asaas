namespace ZDZCode.Payments.Asaas.DTO.PaymentRefund.Request
{
    public class PaymentRefundRequest : BaseAsaasRequest
    {
        public string Payment { get; set; }
        public double? Value { get; set; }
        public string Description { get; set; }
    }
}
