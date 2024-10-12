namespace ZDZCode.Payments.Asaas.Commum
{
    public class SplitResponse 
    {
        public string Id { get; set; }
        public string WalledId { get; set; }
        public double FixedValue { get; set; }
        public double? PercentualValue { get; set; }
        public double TotalValue { get; set; }
        public string CancellationReason { get; set; }
        public string Status { get; set; }
        public string ExternalReference {  get; set; }
        public string Description { get; set; }
    }
}
