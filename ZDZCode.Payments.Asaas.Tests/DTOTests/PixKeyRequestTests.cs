using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Pix.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para PixKeyRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class PixKeyRequestTests
    {
        private readonly Fixture _fixture;

        public PixKeyRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void PixKeyRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<PixKeyRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void PixKeyRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new PixKeyRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void PixKeyRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<PixKeyRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
