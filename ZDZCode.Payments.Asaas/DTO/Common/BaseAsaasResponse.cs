namespace ZDZCode.Payments.Asaas
{
    public class BaseAsaasResponse
    {                
        public int RateLimitLimit { get; set; }
        public int RateLimitRemaining { get; set; }
        public int RateLimitReset { get; set; }
        public bool HasRateLimit { get; set; }
    }
}
