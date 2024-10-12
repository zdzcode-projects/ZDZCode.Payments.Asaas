using ZDZCode.Payments.Asaas.Commum;
using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas.DTO.Subscription.Response
{
    public  class CreateNewSubscriptonResponse
    {
        public string Object {  get; set; }
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Customer {  get; set; }
        public string PaymentLink { get; set; }
        public string BillingType { get; set; }
        public string Cycle { get; set; }
        public double Value { get; set; }
        public DateTime NextDueDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Discount Discount { get; set; }
        public FineResponse Fine { get; set; }
        public InterestResponse Interest { get; set; }
        public bool Deleted { get; set; }
        public int MaxPayments  { get; set; }
        public string ExternalReference { get; set; }
        public IEnumerable<SplitResponse> Split { get; set; }        
    }
}
