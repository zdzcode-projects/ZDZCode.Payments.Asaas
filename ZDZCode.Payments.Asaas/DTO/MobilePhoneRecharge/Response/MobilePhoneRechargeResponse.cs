namespace ZDZCode.Payments.Asaas.DTO.MobilePhoneRecharge.Response
{
    public class MobilePhoneRechargeResponse
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string PhoneNumber { get; set; }
        public double Value { get; set; }
        public string DateCreated { get; set; }
        public string ProviderName { get; set; }
    }
}
