namespace ZDZCode.Payments.Asaas.DTO.Customer.Response
{
    public class ListCustomersResponse
    {
        public string Object {  get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public IEnumerable<CustomerResponse> Data { get; set; }
    }
}
