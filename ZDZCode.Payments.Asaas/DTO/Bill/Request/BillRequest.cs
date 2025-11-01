namespace ZDZCode.Payments.Asaas.DTO.Bill.Request
{
    public class BillRequest : BaseAsaasRequest
    {
        public string IdentificationField { get; set; }
        public string ScheduleDate { get; set; }
        public string Description { get; set; }
        public double? Value { get; set; }
        public double? Discount { get; set; }
    }
}
