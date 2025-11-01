namespace ZDZCode.Payments.Asaas.DTO.Finance.Response
{
    public class FinancePaymentStatisticsResponse
    {
        public double ReceivedValue { get; set; }
        public double OverdueValue { get; set; }
        public double PendingValue { get; set; }
        public int ReceivedCount { get; set; }
        public int OverdueCount { get; set; }
        public int PendingCount { get; set; }
    }
}
