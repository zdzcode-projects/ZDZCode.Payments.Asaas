namespace ZDZCode.Payments.Asaas.Commum
{
    public  class SplitRequest
    {
        public string WalletId { get; set; }
        public double FixedValue { get; set; }
        public double PercentualValue {  get; set; } 
    }
}
