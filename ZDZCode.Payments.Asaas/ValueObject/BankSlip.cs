namespace ZDZCode.Payments.Asaas.ValueObject
{
    public class BankSlip
    {
        public double DefaultValue { get; set; }
        public double? DiscountValue { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int DaysToReceive { get; set; }
    }
}
