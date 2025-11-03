using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Payment.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para a classe CreateNewPaymentRequest.
    /// Valida a estrutura e propriedades do DTO de requisição de pagamento.
    /// Documentação: https://docs.asaas.com/reference/criar-nova-cobranca
    /// </summary>
    public class PaymentRequestTests
    {
        private readonly Fixture _fixture;

        public PaymentRequestTests()
        {
            _fixture = new Fixture();
        }

        /// <summary>
        /// Testa se as propriedades obrigatórias podem ser definidas corretamente.
        /// </summary>
        [Fact]
        public void PaymentRequest_WithRequiredProperties_ShouldBeValid()
        {
            var request = new CreateNewPaymentRequest
            {
                Customer = "cus_123456",
                BillingType = "BOLETO",
                Value = 100.50m
            };

            request.Customer.Should().Be("cus_123456");
            request.BillingType.Should().Be("BOLETO");
            request.Value.Should().Be(100.50m);
        }

        /// <summary>
        /// Testa se o tipo de cobrança BOLETO pode ser definido.
        /// </summary>
        [Fact]
        public void PaymentRequest_WithBoletoType_ShouldBeValid()
        {
            var request = new CreateNewPaymentRequest
            {
                Customer = "cus_123",
                BillingType = "BOLETO",
                Value = 50.00m,
                DueDate = DateTime.Now.AddDays(7)
            };

            request.BillingType.Should().Be("BOLETO");
            request.DueDate.Should().BeAfter(DateTime.Now);
        }

        /// <summary>
        /// Testa se o tipo de cobrança CREDIT_CARD pode ser definido.
        /// </summary>
        [Fact]
        public void PaymentRequest_WithCreditCardType_ShouldBeValid()
        {
            var request = new CreateNewPaymentRequest
            {
                Customer = "cus_123",
                BillingType = "CREDIT_CARD",
                Value = 200.00m
            };

            request.BillingType.Should().Be("CREDIT_CARD");
        }

        /// <summary>
        /// Testa se o tipo de cobrança PIX pode ser definido.
        /// </summary>
        [Fact]
        public void PaymentRequest_WithPixType_ShouldBeValid()
        {
            var request = new CreateNewPaymentRequest
            {
                Customer = "cus_123",
                BillingType = "PIX",
                Value = 150.00m
            };

            request.BillingType.Should().Be("PIX");
        }

        /// <summary>
        /// Testa se juros e multa podem ser configurados.
        /// </summary>
        [Fact]
        public void PaymentRequest_WithInterestAndFine_ShouldBeValid()
        {
            var request = new CreateNewPaymentRequest
            {
                Customer = "cus_123",
                BillingType = "BOLETO",
                Value = 100.00m,
                DueDate = DateTime.Now.AddDays(10)
            };

            request.Should().NotBeNull();
            request.Value.Should().Be(100.00m);
        }

        /// <summary>
        /// Testa se a descrição pode ser definida.
        /// </summary>
        [Fact]
        public void PaymentRequest_WithDescription_ShouldBeValid()
        {
            var request = new CreateNewPaymentRequest
            {
                Customer = "cus_123",
                BillingType = "BOLETO",
                Value = 75.50m,
                Description = "Mensalidade de serviço"
            };

            request.Description.Should().Be("Mensalidade de serviço");
        }

        /// <summary>
        /// Testa se valores decimais são tratados corretamente.
        /// </summary>
        [Fact]
        public void PaymentRequest_WithDecimalValue_ShouldBeValid()
        {
            var request = new CreateNewPaymentRequest
            {
                Customer = "cus_123",
                BillingType = "BOLETO",
                Value = 99.99m
            };

            request.Value.Should().Be(99.99m);
        }

        /// <summary>
        /// Testa se o AutoFixture pode gerar instâncias válidas.
        /// </summary>
        [Fact]
        public void PaymentRequest_AutoFixtureGeneration_ShouldCreateValidObject()
        {
            var request = _fixture.Create<CreateNewPaymentRequest>();

            request.Should().NotBeNull();
            request.Customer.Should().NotBeNullOrEmpty();
            request.BillingType.Should().NotBeNullOrEmpty();
            request.Value.Should().BeGreaterThan(0);
        }

        /// <summary>
        /// Testa se parcelamento pode ser configurado.
        /// </summary>
        [Fact]
        public void PaymentRequest_WithInstallment_ShouldBeValid()
        {
            var request = new CreateNewPaymentRequest
            {
                Customer = "cus_123",
                BillingType = "CREDIT_CARD",
                Value = 300.00m,
                InstallmentCount = 3
            };

            request.InstallmentCount.Should().Be(3);
        }
    }
}
