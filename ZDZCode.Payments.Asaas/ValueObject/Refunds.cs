namespace ZDZCode.Payments.Asaas.ValueObject
{
   public class Refunds
    {
        public string DateCreated { get; set; }
        public string Status { get; set; }
        public double? Value { get; set; }
        public string Description { get; set; }
        public string TransactionReceiptUrl { get; set; }
    }
}
