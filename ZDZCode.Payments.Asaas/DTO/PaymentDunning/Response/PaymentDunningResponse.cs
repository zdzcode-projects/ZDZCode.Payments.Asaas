namespace ZDZCode.Payments.Asaas.DTO.PaymentDunning.Response
{
    public class PaymentDunningResponse
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Payment { get; set; }
        public string Description { get; set; }
        public string[] Documents { get; set; }
        public string DateCreated { get; set; }
    }
}
