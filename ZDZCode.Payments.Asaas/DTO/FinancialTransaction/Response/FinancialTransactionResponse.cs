namespace ZDZCode.Payments.Asaas.DTO.FinancialTransaction.Response
{
    public class FinancialTransactionResponse
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public double Value { get; set; }
        public double Balance { get; set; }
        public string Description { get; set; }
        public string Payment { get; set; }
        public string Installment { get; set; }
        public string Transfer { get; set; }
    }
}
