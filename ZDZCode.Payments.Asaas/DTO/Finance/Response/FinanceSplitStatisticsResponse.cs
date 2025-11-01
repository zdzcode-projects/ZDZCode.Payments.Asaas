namespace ZDZCode.Payments.Asaas.DTO.Finance.Response
{
    public class FinanceSplitStatisticsResponse
    {
        public double TotalValue { get; set; }
        public double ReceivedValue { get; set; }
        public double PendingValue { get; set; }
        public int TotalCount { get; set; }
        public int ReceivedCount { get; set; }
        public int PendingCount { get; set; }
    }
}
