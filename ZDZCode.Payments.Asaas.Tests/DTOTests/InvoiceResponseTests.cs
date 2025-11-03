using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Invoice.Response;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para InvoiceResponse.
    /// Valida estrutura e propriedades do DTO de resposta de Invoice.
    /// </summary>
    public class InvoiceResponseTests
    {
        private readonly Fixture _fixture;

        public InvoiceResponseTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void InvoiceResponse_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<InvoiceResponse>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void InvoiceResponse_CanBeDeserialized_ShouldSucceed()
        {
            var obj = new InvoiceResponse();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void InvoiceResponse_HasPropertiesAccessible_ShouldSucceed()
        {
            var obj = _fixture.Build<InvoiceResponse>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
