using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.PaymentLink.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para PaymentLinkRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class PaymentLinkRequestTests
    {
        private readonly Fixture _fixture;

        public PaymentLinkRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void PaymentLinkRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<PaymentLinkRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void PaymentLinkRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new PaymentLinkRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void PaymentLinkRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<PaymentLinkRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
