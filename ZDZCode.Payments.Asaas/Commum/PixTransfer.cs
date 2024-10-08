namespace ZDZCode.Payments.Asaas.Commum
{
    public  class PixTransfer
    {
        public double FeeValue { get; set; }
        public double? DiscountValue { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool ConsideredInMonthlyTransfersWithoutFee { get; set; }
    }
}
