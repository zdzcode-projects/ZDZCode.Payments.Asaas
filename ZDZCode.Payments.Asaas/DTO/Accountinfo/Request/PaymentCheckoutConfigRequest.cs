namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Request
{
    public class PaymentCheckoutConfigRequest : BaseAsaasRequest
    {
        public string BankSlipConfig { get; set; }
        public string CreditCardConfig { get; set; }
        public string PixConfig { get; set; }
    }
}
