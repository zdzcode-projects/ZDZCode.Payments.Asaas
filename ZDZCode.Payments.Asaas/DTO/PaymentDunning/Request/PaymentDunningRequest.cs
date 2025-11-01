namespace ZDZCode.Payments.Asaas.DTO.PaymentDunning.Request
{
    public class PaymentDunningRequest : BaseAsaasRequest
    {
        public string Payment { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string[] Documents { get; set; }
    }
}
