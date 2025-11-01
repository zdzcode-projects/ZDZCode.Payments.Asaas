using ZDZCode.Payments.Asaas.Commum;

namespace ZDZCode.Payments.Asaas.DTO.Customer.Response
{
    public  class RetrieveNotificationsFromACustomerResponse
    {
        public string Object {  get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public IEnumerable<ZDZCode.Payments.Asaas.ValueObject.Notification> Data { get; set; }

    }
}
