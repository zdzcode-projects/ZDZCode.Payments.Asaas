namespace ZDZCode.Payments.Asaas.DTO.PaymentLink.Response
{
    /// <summary>
    /// Representa a resposta da API ao criar ou consultar um link de pagamento.
    /// Contém apenas os campos essenciais.
    /// </summary>
    public class PaymentLinkResponse
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }
    }
}
