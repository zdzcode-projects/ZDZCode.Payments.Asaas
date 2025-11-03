namespace ZDZCode.Payments.Asaas.DTO.Customer.Response
{
    /// <summary>
    /// Resposta contendo os dados de um cliente.
    /// Documentação: https://docs.asaas.com/reference/listar-clientes
    /// </summary>
    public class CustomerResponse
    {
        /// <summary>
        /// Tipo de objeto (sempre "customer").
        /// </summary>
        public string Object { get; set; }
        
        /// <summary>
        /// Identificador único do cliente.
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Data de criação do cliente.
        /// </summary>
        public DateTime DateCreated { get; set; }
        
        /// <summary>
        /// Nome do cliente.
        /// </summary>
        public string Name { get; set; }
        
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
        /// Código da cidade (IBGE).
        /// </summary>
        public string City { get; set; }
        
        /// <summary>
        /// Nome da cidade.
        /// </summary>
        public string CityName { get; set; }
        
        /// <summary>
        /// Estado (UF).
        /// </summary>
        public string State { get; set; }
        
        /// <summary>
        /// País.
        /// </summary>
        public string Country { get; set; }
        
        /// <summary>
        /// CEP do cliente.
        /// </summary>
        public string PostalCode { get; set; }
        
        /// <summary>
        /// CPF ou CNPJ do cliente.
        /// </summary>
        public string CpfCnpj { get; set; }
        
        /// <summary>
        /// Tipo de pessoa (FISICA ou JURIDICA).
        /// </summary>
        public string PersonType { get; set; }
        
        /// <summary>
        /// Indica se o cliente foi deletado.
        /// </summary>
        public bool? Deleted { get; set; }
        
        /// <summary>
        /// Emails adicionais para envio de notificações.
        /// </summary>
        public string AdditionalEmails { get; set; }
        
        /// <summary>
        /// Referência externa (identificador do seu sistema).
        /// </summary>
        public string ExternalReference { get; set; }
        
        /// <summary>
        /// Indica se as notificações estão desabilitadas.
        /// </summary>
        public bool NotificationDisabled { get; set; }
        
        /// <summary>
        /// Observações sobre o cliente.
        /// </summary>
        public string Observations { get; set; }
    }
}
