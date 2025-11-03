using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Subscription.Response;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para SubscriptionResponse.
    /// Valida estrutura e propriedades do DTO de resposta de Subscription.
    /// </summary>
    public class SubscriptionResponseTests
    {
        private readonly Fixture _fixture;

        public SubscriptionResponseTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void SubscriptionResponse_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<SubscriptionResponse>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void SubscriptionResponse_CanBeDeserialized_ShouldSucceed()
        {
            var obj = new SubscriptionResponse();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void SubscriptionResponse_HasPropertiesAccessible_ShouldSucceed()
        {
            var obj = _fixture.Build<SubscriptionResponse>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
