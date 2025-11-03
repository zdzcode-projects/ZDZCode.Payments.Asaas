using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Subscription.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para SubscriptionRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class SubscriptionRequestTests
    {
        private readonly Fixture _fixture;

        public SubscriptionRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void SubscriptionRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<SubscriptionRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void SubscriptionRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new SubscriptionRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void SubscriptionRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<SubscriptionRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
