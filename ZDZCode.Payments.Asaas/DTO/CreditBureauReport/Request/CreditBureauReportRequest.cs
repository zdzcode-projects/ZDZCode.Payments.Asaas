namespace ZDZCode.Payments.Asaas.DTO.CreditBureauReport.Request
{
    public class CreditBureauReportRequest : BaseAsaasRequest
    {
        public string Customer { get; set; }
        public string CpfCnpj { get; set; }
    }
}
