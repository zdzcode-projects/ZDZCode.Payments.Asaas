namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response
{
    public class MyAccountCommercialInfoResponse
    {
        public string Status { get; set; }
        public string PersonType { get; set; }
        public string CpfCnpj { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string IncomeRange { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string Complement { get; set; }
        public string Province { get; set; }
        public MyAccountCommercialInfoCityResponse City { get; set; }
        public string DenialReason { get; set; }
    }
}
