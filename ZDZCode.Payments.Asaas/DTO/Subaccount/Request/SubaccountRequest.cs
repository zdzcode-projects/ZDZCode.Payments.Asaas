namespace ZDZCode.Payments.Asaas.DTO.Subaccount.Request
{
    public class SubaccountRequest : BaseAsaasRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string LoginEmail { get; set; }
        public string CpfCnpj { get; set; }
        public string BirthDate { get; set; }
        public string CompanyType { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string Complement { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Site { get; set; }
    }
}
