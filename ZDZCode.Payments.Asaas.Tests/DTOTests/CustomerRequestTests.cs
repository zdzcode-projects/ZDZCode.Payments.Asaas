using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Customer.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para a classe CustomerRequest.
    /// Estes testes validam a estrutura e propriedades do DTO de requisição de cliente.
    /// </summary>
    public class CustomerRequestTests
    {
        private readonly Fixture _fixture;

        /// <summary>
        /// Construtor que inicializa o AutoFixture para geração de dados de teste.
        /// </summary>
        public CustomerRequestTests()
        {
            _fixture = new Fixture();
        }

        /// <summary>
        /// Testa se todas as propriedades obrigatórias podem ser definidas corretamente.
        /// </summary>
        [Fact]
        public void CustomerRequest_WithRequiredProperties_ShouldBeValid()
        {
            // Arrange & Act
            var request = new CustomerRequest
            {
                Name = "João Silva",
                CpfCnpj = "12345678901"
            };

            // Assert
            request.Name.Should().Be("João Silva");
            request.CpfCnpj.Should().Be("12345678901");
        }

        /// <summary>
        /// Testa se todas as propriedades opcionais podem ser definidas corretamente.
        /// </summary>
        [Fact]
        public void CustomerRequest_WithAllProperties_ShouldBeValid()
        {
            // Arrange & Act
            var request = new CustomerRequest
            {
                Name = "João Silva",
                CpfCnpj = "12345678901",
                Email = "joao@example.com",
                Phone = "1140001000",
                MobilePhone = "11999990000",
                Address = "Rua Exemplo",
                AddressNumber = "123",
                Complement = "Apto 45",
                Province = "Centro",
                PostalCode = "01310-100",
                ExternalReference = "REF001",
                NotificationDisabled = false,
                AdditionalEmails = "joao2@example.com,joao3@example.com",
                MunicipalInscription = "123456",
                StateInscription = "789012",
                Observations = "Cliente VIP",
                GroupName = "Grupo A",
                Company = "Empresa XYZ"
            };

            // Assert
            request.Name.Should().Be("João Silva");
            request.CpfCnpj.Should().Be("12345678901");
            request.Email.Should().Be("joao@example.com");
            request.Phone.Should().Be("1140001000");
            request.MobilePhone.Should().Be("11999990000");
            request.Address.Should().Be("Rua Exemplo");
            request.AddressNumber.Should().Be("123");
            request.Complement.Should().Be("Apto 45");
            request.Province.Should().Be("Centro");
            request.PostalCode.Should().Be("01310-100");
            request.ExternalReference.Should().Be("REF001");
            request.NotificationDisabled.Should().BeFalse();
            request.AdditionalEmails.Should().Be("joao2@example.com,joao3@example.com");
            request.MunicipalInscription.Should().Be("123456");
            request.StateInscription.Should().Be("789012");
            request.Observations.Should().Be("Cliente VIP");
            request.GroupName.Should().Be("Grupo A");
            request.Company.Should().Be("Empresa XYZ");
        }

        /// <summary>
        /// Testa se o AutoFixture pode gerar instâncias válidas do CustomerRequest.
        /// </summary>
        [Fact]
        public void CustomerRequest_AutoFixtureGeneration_ShouldCreateValidObject()
        {
            // Arrange & Act
            var request = _fixture.Create<CustomerRequest>();

            // Assert
            request.Should().NotBeNull();
            request.Name.Should().NotBeNullOrEmpty();
            request.CpfCnpj.Should().NotBeNullOrEmpty();
        }

        /// <summary>
        /// Testa se múltiplos emails adicionais podem ser configurados corretamente.
        /// </summary>
        [Fact]
        public void CustomerRequest_WithMultipleAdditionalEmails_ShouldBeValid()
        {
            // Arrange & Act
            var request = new CustomerRequest
            {
                Name = "João Silva",
                CpfCnpj = "12345678901",
                Email = "joao@example.com",
                AdditionalEmails = "email1@example.com,email2@example.com,email3@example.com"
            };

            // Assert
            request.AdditionalEmails.Should().Contain("email1@example.com");
            request.AdditionalEmails.Should().Contain("email2@example.com");
            request.AdditionalEmails.Should().Contain("email3@example.com");
        }

        /// <summary>
        /// Testa se o CPF pode ser definido corretamente (pessoa física).
        /// </summary>
        [Fact]
        public void CustomerRequest_WithCpf_ShouldBeValid()
        {
            // Arrange & Act
            var request = new CustomerRequest
            {
                Name = "João Silva",
                CpfCnpj = "12345678901" // CPF
            };

            // Assert
            request.CpfCnpj.Should().Be("12345678901");
            request.CpfCnpj.Length.Should().Be(11);
        }

        /// <summary>
        /// Testa se o CNPJ pode ser definido corretamente (pessoa jurídica).
        /// </summary>
        [Fact]
        public void CustomerRequest_WithCnpj_ShouldBeValid()
        {
            // Arrange & Act
            var request = new CustomerRequest
            {
                Name = "Empresa XYZ Ltda",
                CpfCnpj = "12345678000199" // CNPJ
            };

            // Assert
            request.CpfCnpj.Should().Be("12345678000199");
            request.CpfCnpj.Length.Should().Be(14);
        }

        /// <summary>
        /// Testa se as notificações podem ser desabilitadas.
        /// </summary>
        [Fact]
        public void CustomerRequest_WithNotificationsDisabled_ShouldBeValid()
        {
            // Arrange & Act
            var request = new CustomerRequest
            {
                Name = "João Silva",
                CpfCnpj = "12345678901",
                NotificationDisabled = true
            };

            // Assert
            request.NotificationDisabled.Should().BeTrue();
        }
    }
}
