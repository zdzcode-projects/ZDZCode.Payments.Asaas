

using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response
{
    public  class RetrieveAccountFeesResponse
    {
        public Pagamento Payment { get; set; }
        public ZDZCode.Payments.Asaas.ValueObject.Transfer Transfer { get; set; }
        public Notification Notification { get; set; }
        public CreditBureauReport CreditBureauReport { get; set; }
        public Invoice Invoice { get; set; }
        public Anticipation Anticipation { get; set; }
    }
}
