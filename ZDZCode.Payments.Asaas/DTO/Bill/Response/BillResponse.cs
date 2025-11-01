namespace ZDZCode.Payments.Asaas.DTO.Bill.Response
{
    public class BillResponse
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public string Status { get; set; }
        public string IdentificationField { get; set; }
        public string ScheduleDate { get; set; }
        public string PaymentDate { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public double? Discount { get; set; }
        public double? Fee { get; set; }
        public bool CanBeCancelled { get; set; }
    }
}
