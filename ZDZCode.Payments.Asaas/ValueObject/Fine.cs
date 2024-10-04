namespace ZDZCode.Payments.Asaas.ValueObject
{
    public record Fine
    {
        public decimal Value { get; set; }
        public Type Type { get; set; }
    }
}
