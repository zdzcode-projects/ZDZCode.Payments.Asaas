namespace ZDZCode.Payments.Asaas.ValueObject
{
    public class CreditCard
    {
        public double OperationValue { get; set; }
        public double OneInstallmentPercentage { get; set; }
        public double UpToSixInstallmentsPercentage { get; set; }
        public double UpToTwelveInstallmentsPercentage { get; set; }
        public double? DiscountOneInstallmentPercentage { get; set; }
        public double? DiscountUpToSixInstallmentsPercentage { get; set; }
        public double? DiscountUpToTwelveInstallmentsPercentage { get; set; }
        public DateTime? DiscountExpiration { get; set; }
        public int DaysToReceive { get; set; }
    }
}
