namespace ZDZCode.Payments.Asaas.ValueObject
{
    public  class Split
    {
        public string WalletId { get; set; }
        public decimal? FixedValue { get; set; }
        public decimal? PercentualValue { get; set; }
        public decimal? TotalFixedValue { get; set; }
        public string ExternalReference { get; set; }
        public string Description { get; set; }
    }
}
