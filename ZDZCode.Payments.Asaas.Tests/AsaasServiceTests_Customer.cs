using FluentAssertions;
using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.DTO.Customer.Request;

namespace ZDZCode.Payments.Asaas.Tests
{
    public partial class AsaasServiceTests
    {
        [Fact]
        public async Task PostCreatedNewCustomer()
        {
            var request = new CustomerRequest            
            {
                Name = "John Doe",
                CpfCnpj = "24971563792",
                Email = "john.doe@asaas.com.br",
                Phone = "4738010919",
                MobilePhone = "4799376637",
                Address = "Av. Paulista",
                AddressNumber = "150",
                Complement = "Sala 201",
                Province = "Centro",
                PostalCode = "01310-000",
                ExternalReference = "12987382",
                NotificationDisabled = false,
                AdditionalEmails = "john.doe@asaas.com,john.doe.silva@asaas.com.br",
                MunicipalInscription = "46683695908",
                StateInscription = "646681195275",
                Observations = "great payer, no problems so far",
                GroupName = null,
                Company = null
            };

            var result = await _asaasService.CreateNewCustomer(request);

            result.Should().Be(result);
        }

    }
}
