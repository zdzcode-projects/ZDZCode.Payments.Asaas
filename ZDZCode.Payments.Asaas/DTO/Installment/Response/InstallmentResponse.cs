namespace ZDZCode.Payments.Asaas.DTO.Installment.Response
{
    public class InstallmentResponse
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public string DateCreated { get; set; }
        public string Customer { get; set; }
        public string PaymentLink { get; set; }
        public string BillingType { get; set; }
        public double Value { get; set; }
        public string NetValue { get; set; }
        public string Description { get; set; }
        public string ExternalReference { get; set; }
        public string Status { get; set; }
        public bool Deleted { get; set; }
        public object Fine { get; set; }
        public object Interest { get; set; }
        public object Discount { get; set; }
        public object Split { get; set; }
    }
}
