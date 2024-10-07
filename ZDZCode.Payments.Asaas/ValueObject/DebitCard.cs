namespace ZDZCode.Payments.Asaas.ValueObject
{
    public  class DebitCard
    {
        public double OperationValue { get; set; }
        public double DefaultPercentage { get; set; }
        public int DaysToReceive { get; set; }
    }
}
