namespace ZDZCode.Payments.Asaas.DTO.PaymentSplit.Request
{
    public class PaymentSplitRequest : BaseAsaasRequest
    {
        public string Payment { get; set; }
        public string WalletId { get; set; }
        public double? FixedValue { get; set; }
        public double? PercentualValue { get; set; }
        public string ExternalReference { get; set; }
        public string Description { get; set; }
    }
}
