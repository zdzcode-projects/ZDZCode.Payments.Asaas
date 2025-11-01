namespace ZDZCode.Payments.Asaas.DTO.Invoice.Request
{
    public class InvoiceRequest : BaseAsaasRequest
    {
        public string Payment { get; set; }
        public string InstallmentId { get; set; }
        public string ServiceDescription { get; set; }
        public string ObservationLine { get; set; }
        public string ExternalReference { get; set; }
        public string EffectiveDate { get; set; }
        public string MunicipalServiceId { get; set; }
        public string MunicipalServiceCode { get; set; }
        public string MunicipalServiceName { get; set; }
        public double? Deductions { get; set; }
        public object Taxes { get; set; }
    }
}
