using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas.DataListResponse
{
    public class DataListPaymentsWithSummaryData
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string CustomerId { get; set; }
        public string SubscriptionId { get; set; }
        public string InstallmentId { get; set; }
        public string PaymentLinkId { get; set; }
        public double Value { get; set; }
        public double NetValue  { get; set; }
        public double? OriginalValue { get; set; }
        public double? InterestValue   { get; set; }
        public string Description { get; set; }
        public string DescriptionType { get; set; }
        public string BillingType   { get; set; }
        public bool CanBePaidAfterDueDate { get; set; }
        public DateTime ConfirmedDate {  get; set; }
        public string PixTransactionId { get; set; }
        public string Status {  get; set; }
        public DateTime DueDate { get; set; }
        public DateTime OriginalDueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime CustomerPaymentDate { get; set; }
        public double? InstallmentNumber     { get; set; }
        public string ExternalReference { get; set; }
        public bool Deleted {  get; set; }
        public bool Anticipated { get; set; }
        public bool Anticipable { get; set; }
        public DateTime CreditDate { get; set; }
        public string TransactionReceipUrl { get; set; }
        public string DuplicatedPaymentId { get; set; }
        public Discount Discount { get; set; }
        public FineResponse Fine { get; set; }
        public InterestResponse Interest { get; set; }
        public bool PostalService { get; set; }
    }
}
