namespace ZDZCode.Payments.Asaas.DTO.Notification.Request
{
    public class NotificationBatchRequest : BaseAsaasRequest
    {
        public string Customer { get; set; }
        public bool? EmailEnabledForProvider { get; set; }
        public bool? SmsEnabledForProvider { get; set; }
        public bool? PhoneCallEnabledForProvider { get; set; }
        public bool? WhatsappEnabledForProvider { get; set; }
    }
}
