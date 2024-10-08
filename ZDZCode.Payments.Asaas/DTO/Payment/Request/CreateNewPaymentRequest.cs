using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas.DTO.Payment.Request
{
    public  class CreateNewPaymentRequest
    {
        public string Customer {  get; set; }
        public string BillingType { get; set; }
        public decimal Value {  get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public int DaysAfterDueDateToRegistrationCancellation { get; set; }
        public  string ExternalReference { get; set; }
        public int? InstallmentCount { get; set; }
        public double? TotalValue { get; set; }
        public double? InstallmentValue { get; set; }
        public Discount Discount { get; set; }
        public Interest Interest { get; set; }
        public Fine Fine { get; set; }
        public bool PostalService { get; set; }
        public List<Split> Slip { get; set; }
        public CallBack CallBack { get; set; }
        
    }
}
