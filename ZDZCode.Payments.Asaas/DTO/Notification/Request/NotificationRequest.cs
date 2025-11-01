namespace ZDZCode.Payments.Asaas.DTO.Notification.Request
{
    public class NotificationRequest : BaseAsaasRequest
    {
        public string Customer { get; set; }
        public bool? SendEmail { get; set; }
        public bool? SendSms { get; set; }
        public string EmailScheduleDate { get; set; }
        public string SmsScheduleDate { get; set; }
    }
}
