namespace ZDZCode.Payments.Asaas.DTO.PaymentDunning.Response
{
    public class PaymentDunningHistoryResponse
    {
        public string Object { get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public object[] Data { get; set; }
    }
}
