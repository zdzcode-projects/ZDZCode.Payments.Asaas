using ZDZCode.Payments.Asaas.ValueObject;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response
{
    public class MyAccountCommercialInfoResponse
    {
        public string Status { get; set; }
        public string PersonType { get; set; }
        public string CpfCnpj { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public decimal IncomeValue { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string Complement { get; set; }
        public string Province { get; set; }
        public City City { get; set; }
        public string DenialReason { get; set; }
        public string TradingName { get; set; }
        public string Site { get; set; }
        public CommercialInfoExpiration CommercialInfoExpiration { get; set; }


    }
}
