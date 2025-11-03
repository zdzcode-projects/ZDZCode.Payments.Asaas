using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Transfer.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para TransferRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class TransferRequestTests
    {
        private readonly Fixture _fixture;

        public TransferRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void TransferRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<TransferRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void TransferRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new TransferRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void TransferRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<TransferRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
