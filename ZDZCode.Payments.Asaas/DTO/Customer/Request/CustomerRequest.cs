namespace ZDZCode.Payments.Asaas.DTO.Customer.Request
{
    /// <summary>
    /// Requisição para criar ou atualizar um cliente.
    /// Documentação: https://docs.asaas.com/reference/criar-novo-cliente
    /// </summary>
    public class CustomerRequest
    {
        /// <summary>
        /// Nome do cliente (obrigatório).
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// CPF ou CNPJ do cliente (obrigatório).
        /// </summary>
        public string CpfCnpj { get; set; }
        
        /// <summary>
        /// Email do cliente.
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Telefone fixo do cliente.
        /// </summary>
        public string Phone { get; set; }
        
        /// <summary>
        /// Telefone celular do cliente.
        /// </summary>
        public string MobilePhone { get; set; }
        
        /// <summary>
        /// Endereço do cliente.
        /// </summary>
        public string Address { get; set; }
        
        /// <summary>
        /// Número do endereço.
        /// </summary>
        public string AddressNumber { get; set; }
        
        /// <summary>
        /// Complemento do endereço.
        /// </summary>
        public string Complement {  get; set; }
        
        /// <summary>
        /// Bairro do cliente.
        /// </summary>
        public string Province { get; set; }
        
        /// <summary>
        /// CEP do cliente.
        /// </summary>
        public string PostalCode { get; set; }
        
        /// <summary>
        /// Referência externa (identificador do seu sistema).
        /// </summary>
        public string ExternalReference { get; set; }
        
        /// <summary>
        /// Indica se as notificações devem ser desabilitadas.
        /// </summary>
        public bool? NotificationDisabled { get; set; }
        
        /// <summary>
        /// Emails adicionais para envio de notificações (separados por vírgula).
        /// </summary>
        public string AdditionalEmails { get; set; }
        
        /// <summary>
        /// Inscrição municipal do cliente.
        /// </summary>
        public string MunicipalInscription { get; set; }
        
        /// <summary>
        /// Inscrição estadual do cliente.
        /// </summary>
        public string StateInscription { get; set; }
        
        /// <summary>
        /// Observações sobre o cliente.
        /// </summary>
        public string Observations { get; set; }
        
        /// <summary>
        /// Nome do grupo ao qual o cliente pertence.
        /// </summary>
        public string GroupName { get; set; }
        
        /// <summary>
        /// Nome da empresa do cliente.
        /// </summary>
        public string Company { get; set; }
    }
}
