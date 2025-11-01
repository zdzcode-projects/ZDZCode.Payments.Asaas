namespace ZDZCode.Payments.Asaas.DTO.Subscription.Request
{
    public class SubscriptionInvoiceSettingsRequest : BaseAsaasRequest
    {
        public string MunicipalServiceId { get; set; }
        public string MunicipalServiceCode { get; set; }
        public string MunicipalServiceName { get; set; }
        public bool? UpdatePayment { get; set; }
        public string Observations { get; set; }
        public object Taxes { get; set; }
        public double? Deductions { get; set; }
        public string EffectiveDatePeriod { get; set; }
        public int? DaysBeforeDueDate { get; set; }
        public string ReceivedOnly { get; set; }
    }
}
