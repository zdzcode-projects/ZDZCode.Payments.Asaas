

using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response
{
    public  class RetrieveAccountFeesResponse
    {
        public Pagamento Payment { get; set; }
        public ZDZCode.Payments.Asaas.ValueObject.Transfer Transfer { get; set; }
        public ZDZCode.Payments.Asaas.ValueObject.Notification Notification { get; set; }
        public CreditBureauReport CreditBureauReport { get; set; }
        public ZDZCode.Payments.Asaas.ValueObject.Invoice Invoice { get; set; }
        public ZDZCode.Payments.Asaas.ValueObject.Anticipation Anticipation { get; set; }
    }
}
