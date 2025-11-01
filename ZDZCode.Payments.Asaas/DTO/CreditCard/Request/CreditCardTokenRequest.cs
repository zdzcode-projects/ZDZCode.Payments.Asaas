namespace ZDZCode.Payments.Asaas.DTO.CreditCard.Request
{
    public class CreditCardTokenRequest : BaseAsaasRequest
    {
        public string Customer { get; set; }
        public string CreditCard { get; set; }
        public string CreditCardHolderName { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardExpiryMonth { get; set; }
        public string CreditCardExpiryYear { get; set; }
        public string CreditCardCcv { get; set; }
    }
}
