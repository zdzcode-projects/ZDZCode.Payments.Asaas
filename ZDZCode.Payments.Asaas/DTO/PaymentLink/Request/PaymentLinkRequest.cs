namespace ZDZCode.Payments.Asaas.DTO.PaymentLink.Request
{
    /// <summary>
    /// Representa os dados necessários para criação de um link de pagamento no Asaas.
    /// Apenas um subconjunto dos campos disponíveis na API é exposto aqui para manter o exemplo simples.
    /// </summary>
    public class PaymentLinkRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public string BillingType { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
