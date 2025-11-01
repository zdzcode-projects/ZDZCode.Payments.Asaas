namespace ZDZCode.Payments.Asaas.DTO.Invoice.Response
{
    public class InvoiceResponse
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public string Status { get; set; }
        public string Customer { get; set; }
        public string Type { get; set; }
        public string ServiceDescription { get; set; }
        public string PdfUrl { get; set; }
        public string XmlUrl { get; set; }
        public string RpsSerie { get; set; }
        public string RpsNumber { get; set; }
        public string Number { get; set; }
        public string ValidationCode { get; set; }
        public double Value { get; set; }
        public double? Deductions { get; set; }
        public string EffectiveDate { get; set; }
        public string Observations { get; set; }
        public object Taxes { get; set; }
    }
}
