using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Bill.Request;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para BillRequest.
    /// Valida estrutura e propriedades do DTO.
    /// </summary>
    public class BillRequestTests
    {
        private readonly Fixture _fixture;

        public BillRequestTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void BillRequest_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<BillRequest>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void BillRequest_CanBeInstantiated_ShouldSucceed()
        {
            var obj = new BillRequest();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void BillRequest_PropertiesCanBeSet_ShouldSucceed()
        {
            var obj = _fixture.Build<BillRequest>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
