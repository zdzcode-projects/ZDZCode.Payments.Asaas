namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Request
{
    public class UpdateBusinessDataRequest
    {
        public string PersonType { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime BirthDate { get; set; }
        public string CompanyType { get; set; }
        public decimal IncomeValue { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobileNumber { get; set; }
        public string Site { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string Complement { get; set; }
        public string Province { get; set; }
    }
}
