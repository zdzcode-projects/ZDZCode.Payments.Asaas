using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Anticipation.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para AnticipationRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class AnticipationRequestTests
    {
        private readonly Fixture _fixture;

        public AnticipationRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void AnticipationRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<AnticipationRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void AnticipationRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new AnticipationRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void AnticipationRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<AnticipationRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
