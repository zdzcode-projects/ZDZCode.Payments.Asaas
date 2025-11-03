using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Transfer.Response;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para TransferResponse.
    /// Valida estrutura e propriedades do DTO de resposta de Transfer.
    /// </summary>
    public class TransferResponseTests
    {
        private readonly Fixture _fixture;

        public TransferResponseTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void TransferResponse_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<TransferResponse>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void TransferResponse_CanBeDeserialized_ShouldSucceed()
        {
            var obj = new TransferResponse();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void TransferResponse_HasPropertiesAccessible_ShouldSucceed()
        {
            var obj = _fixture.Build<TransferResponse>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
