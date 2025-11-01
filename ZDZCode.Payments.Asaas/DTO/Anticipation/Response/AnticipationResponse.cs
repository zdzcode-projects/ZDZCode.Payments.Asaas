namespace ZDZCode.Payments.Asaas.DTO.Anticipation.Response
{
    public class AnticipationResponse
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public string Status { get; set; }
        public double RequestValue { get; set; }
        public double TotalValue { get; set; }
        public double NetValue { get; set; }
        public string PaymentDate { get; set; }
        public string BankAccountId { get; set; }
    }
}
