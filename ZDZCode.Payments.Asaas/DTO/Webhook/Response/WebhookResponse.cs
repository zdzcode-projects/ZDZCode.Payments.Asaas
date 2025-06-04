namespace ZDZCode.Payments.Asaas.DTO.Webhook.Response
{
    /// <summary>
    /// Representa a resposta retornada pela API ao cadastrar ou consultar um webhook.
    /// </summary>
    public class WebhookResponse
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }
    }
}
