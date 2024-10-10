namespace ZDZCode.Payments.Asaas.Commum
{
    public  class ListPageResponse<T>
    {
        public string Object {  get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
    }
}
