using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas.DTO.Payment.Response
{
    public class CreateNewPaymentResponse
    {
        public string Object {  get; set; }
        public string Id { get; set; }
        public string Customer {  get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        public string Installment {  get; set; }
        public string Subscription {  get; set; }
        public string PaymentLink { get; set; }
        public double Value { get; set; }
        public double NetValue { get; set; }
        public string BillingType { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int? DaysAfterDueDateToRegistrationCancellation { get; set; }
        public string ExternalReference { get; set; }
        public bool CanBePaidAfterDueDate { get; set; }
        public string PixTransaction { get; set; }
        public string PixQrCodeId { get; set; }
        public decimal? OriginalValue { get; set; }
        public decimal? InterestValue { get; set; }
        public string OriginalDueDate { get; set; }
        public string PaymentDate { get; set; }
        public string ClientPaymentDate { get; set; }
        public int? InstallmentNumber { get; set; }
        public string TransactionReceiptUrl { get; set; }
        public string NossoNumero { get; set; }
        public string InvoiceUrl { get; set; }
        public string BankSlipUrl { get; set; }
        public string InvoiceNumber { get; set; }
        public Discount Discount { get; set; }
        public Fine Fine { get; set; }
        public Interest Interest { get; set; }
        public bool Deleted { get; set; }
        public bool PostalService { get; set; }
        public bool Anticipated { get; set; }
        public bool Anticipable { get; set; }
        public List<Refunds> Refunds { get; set; }
        public List<Split> Split { get; set; }
        public ChargeBack ChargeBack { get; set; }
    }
}
