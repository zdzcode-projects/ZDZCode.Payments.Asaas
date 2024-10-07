namespace ZDZCode.Payments.Asaas.ValueObject
{
    public  class Pix
    {
        public double FixedFeeValue { get; set; }
        public double FixedFeeValueWithDiscount { get; set; }
        public double PercentageFee { get; set; }
        public double MinimumFeeValue { get; set; }
        public double MaximumFeeValue { get; set; }
        public DateTime? DiscountExpiration { get; set; }
        public int MonthlyCreditsWithoutFee { get; set; }
        public int CreditsReceivedOfCurrentMonth{ get; set; }
    }
}
