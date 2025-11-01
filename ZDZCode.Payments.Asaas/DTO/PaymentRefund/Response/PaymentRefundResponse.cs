namespace ZDZCode.Payments.Asaas.DTO.PaymentRefund.Response
{
    public class PaymentRefundResponse
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public string DateCreated { get; set; }
        public string Status { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public string TransactionReceiptUrl { get; set; }
    }
}
