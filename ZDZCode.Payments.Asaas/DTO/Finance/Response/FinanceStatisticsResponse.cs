namespace ZDZCode.Payments.Asaas.DTO.Finance.Response
{
    public class FinanceStatisticsResponse
    {
        public double Balance { get; set; }
        public double BalanceBlockedInAnticipation { get; set; }
        public double TransactionValue { get; set; }
        public double AnticipationValue { get; set; }
        public double TransferValue { get; set; }
    }
}
