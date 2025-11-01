namespace ZDZCode.Payments.Asaas.DTO.PaymentSplit.Response
{
    public class PaymentSplitResponse
    {
        public string Id { get; set; }
        public string WalletId { get; set; }
        public double? FixedValue { get; set; }
        public double? PercentualValue { get; set; }
        public double TotalValue { get; set; }
        public string Status { get; set; }
        public string RefusalReason { get; set; }
        public string ExternalReference { get; set; }
        public string Description { get; set; }
    }
}
