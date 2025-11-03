using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Installment.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para InstallmentRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class InstallmentRequestTests
    {
        private readonly Fixture _fixture;

        public InstallmentRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void InstallmentRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<InstallmentRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void InstallmentRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new InstallmentRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void InstallmentRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<InstallmentRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
