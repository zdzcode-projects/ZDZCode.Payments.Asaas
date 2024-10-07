namespace ZDZCode.Payments.Asaas.ValueObject
{
    public class BankSlip
    {
        public decimal DefaultValue { get; set; }
        public decimal DiscountValue { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int DaysToReceive { get; set; }
    }
}
