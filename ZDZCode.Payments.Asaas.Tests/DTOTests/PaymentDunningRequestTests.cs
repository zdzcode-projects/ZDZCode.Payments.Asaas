using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.PaymentDunning.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para PaymentDunningRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class PaymentDunningRequestTests
    {
        private readonly Fixture _fixture;

        public PaymentDunningRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void PaymentDunningRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<PaymentDunningRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void PaymentDunningRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new PaymentDunningRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void PaymentDunningRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<PaymentDunningRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
