namespace ZDZCode.Payments.Asaas.DTO.Anticipation.Request
{
    public class AnticipationRequest : BaseAsaasRequest
    {
        public string Payment { get; set; }
        public string Installment { get; set; }
    }
}
