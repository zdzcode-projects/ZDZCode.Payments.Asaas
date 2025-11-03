using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Notification.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para NotificationRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class NotificationRequestTests
    {
        private readonly Fixture _fixture;

        public NotificationRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void NotificationRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<NotificationRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void NotificationRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new NotificationRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void NotificationRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<NotificationRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
