namespace ZDZCode.Payments.Asaas.ValueObject
{
    public  class Discount
    {
        public double Value { get; set; }
        public int DueDateLimitDays { get; set; }
        public string Type { get; set; }
    }
}
