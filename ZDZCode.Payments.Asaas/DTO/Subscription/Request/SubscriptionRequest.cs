namespace ZDZCode.Payments.Asaas.DTO.Subscription.Request
{
    public class SubscriptionRequest : BaseAsaasRequest
    {
        public string Customer { get; set; }
        public string BillingType { get; set; }
        public double Value { get; set; }
        public string NextDueDate { get; set; }
        public string Cycle { get; set; }
        public string Description { get; set; }
        public string EndDate { get; set; }
        public int? MaxPayments { get; set; }
        public string ExternalReference { get; set; }
        public object Fine { get; set; }
        public object Interest { get; set; }
        public object Discount { get; set; }
        public object Split { get; set; }
        public bool? UpdatePendingPayments { get; set; }
    }
}
