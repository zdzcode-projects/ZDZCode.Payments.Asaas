namespace ZDZCode.Payments.Asaas.ValueObject
{
    public record Callback
    {
        public string SuccessUrl { get; set; }
        public bool AutoRedirect { get; set; }

    }
}
