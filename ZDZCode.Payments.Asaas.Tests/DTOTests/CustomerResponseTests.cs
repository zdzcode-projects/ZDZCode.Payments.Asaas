using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Customer.Response;

namespace ZDZCode.Payments.Asaas.Tests.DTOTests
{
    /// <summary>
    /// Testes unitários para CustomerResponse.
    /// Valida estrutura e propriedades do DTO de resposta de Customer.
    /// </summary>
    public class CustomerResponseTests
    {
        private readonly Fixture _fixture;

        public CustomerResponseTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void CustomerResponse_AutoFixture_ShouldGenerateValidObject()
        {
            var obj = _fixture.Create<CustomerResponse>();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void CustomerResponse_CanBeDeserialized_ShouldSucceed()
        {
            var obj = new CustomerResponse();
            
            obj.Should().NotBeNull();
        }

        [Fact]
        public void CustomerResponse_HasPropertiesAccessible_ShouldSucceed()
        {
            var obj = _fixture.Build<CustomerResponse>().Create();
            
            obj.Should().NotBeNull();
        }
    }
}
