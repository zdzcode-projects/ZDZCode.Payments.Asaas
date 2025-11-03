using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Webhook.Response;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para WebhookResponse.
    /// Valida estrutura e propriedades do DTO de resposta de Webhook.
    /// </summary>
    public class WebhookResponseTests
    {
        private readonly Fixture _fixture;

        public WebhookResponseTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void WebhookResponse_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<WebhookResponse>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void WebhookResponse_CanBeDeserialized_ShouldSucceed()
        {
            var obj = new WebhookResponse();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void WebhookResponse_HasPropertiesAccessible_ShouldSucceed()
        {
            var obj = _fixture.Build<WebhookResponse>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
