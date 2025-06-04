namespace ZDZCode.Payments.Asaas.DTO.Webhook.Request
{
    /// <summary>
    /// Representa os dados necessários para cadastrar um webhook no Asaas.
    /// </summary>
    public class WebhookRequest
    {
        public string Url { get; set; }
        public string Email { get; set; }
        public string ApiVersion { get; set; }
    }
}
