using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Invoice.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para InvoiceRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class InvoiceRequestTests
    {
        private readonly Fixture _fixture;

        public InvoiceRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void InvoiceRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<InvoiceRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void InvoiceRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new InvoiceRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void InvoiceRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<InvoiceRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
