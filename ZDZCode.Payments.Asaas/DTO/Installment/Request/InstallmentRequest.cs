namespace ZDZCode.Payments.Asaas.DTO.Installment.Request
{
    public class InstallmentRequest : BaseAsaasRequest
    {
        public string Customer { get; set; }
        public string BillingType { get; set; }
        public double Value { get; set; }
        public string DueDate { get; set; }
        public int InstallmentCount { get; set; }
        public double? InstallmentValue { get; set; }
        public string Description { get; set; }
        public string ExternalReference { get; set; }
        public object Fine { get; set; }
        public object Interest { get; set; }
        public object Discount { get; set; }
        public object Split { get; set; }
    }
}
