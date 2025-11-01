namespace ZDZCode.Payments.Asaas.DTO.MobilePhoneRecharge.Request
{
    public class MobilePhoneRechargeRequest : BaseAsaasRequest
    {
        public string PhoneNumber { get; set; }
        public double Value { get; set; }
    }
}
