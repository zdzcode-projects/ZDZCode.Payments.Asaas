namespace ZDZCode.Payments.Asaas.DTO.Transfer.Request
{
    /// <summary>
    /// Representa os dados necessários para criação de uma transferência.
    /// </summary>
    public class TransferRequest
    {
        public string WalletId { get; set; }
        public decimal Value { get; set; }
        public string Description { get; set; }
    }
}
