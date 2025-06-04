namespace ZDZCode.Payments.Asaas.DTO.Transfer.Response
{
    /// <summary>
    /// Representa a resposta de uma transferência.
    /// </summary>
    public class TransferResponse
    {
        public string Id { get; set; }
        public decimal Value { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
