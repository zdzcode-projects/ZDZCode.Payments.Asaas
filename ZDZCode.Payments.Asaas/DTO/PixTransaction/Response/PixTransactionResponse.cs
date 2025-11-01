namespace ZDZCode.Payments.Asaas.DTO.PixTransaction.Response
{
    public class PixTransactionResponse
    {
        public string Id { get; set; }
        public string EndToEndIdentifier { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }
        public string Status { get; set; }
        public string EffectiveDate { get; set; }
        public string ScheduledDate { get; set; }
        public string Description { get; set; }
        public string Payment { get; set; }
        public object Payer { get; set; }
        public object QrCode { get; set; }
    }
}
