namespace ZDZCode.Payments.Asaas.Commum
{
    public  class Notification
    {
        public string Object {  get; set; }
        public string Id { get; set; }
        public string Customer {  get; set; }
        public bool Enabled { get; set; }
        public bool EmailEnabledForProvider { get; set; }
        public bool SmsEnabledForProvider { get; set; }
        public bool EmailEnabledForCustomer { get; set; }
        public bool PhoneCallEnabledForCustomer { get; set; }
        public bool WhatsappEnabledForCustomer { get; set; }
        public string Event { get; set; }
        public int ScheduleOffset { get; set; }
        public bool Deleted { get; set; }
    }
}
