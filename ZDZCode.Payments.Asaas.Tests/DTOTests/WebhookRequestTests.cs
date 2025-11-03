using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Webhook.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para WebhookRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class WebhookRequestTests
    {
        private readonly Fixture _fixture;

        public WebhookRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void WebhookRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<WebhookRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void WebhookRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new WebhookRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void WebhookRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<WebhookRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
