using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas.DTO.Payment.Response
{
    public class CreateNewPaymentWithSummaryDataResponse
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string CustomerId { get; set; }
        public string SubscriptionId { get; set; }
        public string InstallmentId { get; set; }
        public string PaymentLinkId { get; set; }
        public decimal Value { get; set; }
        public decimal NetValue { get; set; }
        public decimal? OriginalValue { get; set; }
        public decimal? InterestValue { get; set; }
        public string Description { get; set; }
        public string BillingType { get; set; }
        public bool CanBePaidAfterDueDate { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public string PixTransactionId { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime OriginalDueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? CustomerPaymentDate { get; set; }
        public int? InstallmentNumber { get; set; }
        public string ExternalReference { get; set; }
        public bool Deleted { get; set; }
        public bool Anticipated { get; set; }
        public bool Anticipable { get; set; }
        public DateTime CreditDate { get; set; }
        public string TransactionReceiptUrl { get; set; }
        public string DuplicatedPaymentId { get; set; }
        public Discount Discount { get; set; }
        public Fine Fine { get; set; }
        public Interest Interest { get; set; }
        public bool PostalService { get; set; }
    }
}
