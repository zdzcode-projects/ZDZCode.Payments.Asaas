using AutoFixture;
using DocumentFormat.OpenXml.Office2010.Excel;
using FluentAssertions;
using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.DTO.Customer.Request;
using ZDZCode.Payments.Asaas.DTO.Payment.Request;

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

        [Fact]
        public async Task ListCustomers()
        {
            var result = await _asaasService.GetListCustomers();

            result.Should().NotBeNull();
        }

        [Fact]
        public void GetRetrieveSingleCustomer()
        {
            var request = "cus_000006258699";

            var result = _asaasService.GetRetrieveASingleCustomer(request);

            result.Should().NotBeNull();
        }

        [Fact]
        public void UpdateExistingCustomer()
        {
            var requestId = "cus_000006258699";

            var request = _fixture
                .Build<CustomerRequest>()
                .Create();

            var result = _asaasService.UpdateExistingCustomer(requestId, request);

            result.Should().NotBeNull();          
                
        }

        [Fact]
        public void RemoverCustomer()
        {
            var request = "cus_000006258699";

            var result = _asaasService.RemoveCustomer(request);

            result.Should().NotBeNull();
        }

        [Fact]
        public void RestoreRemovedCustomer()
        {
            var request = "cus_000006258699";

            var result = _asaasService.RestoreRemovedCustomer(request);

            result.Should().NotBeNull();
        }

        [Fact]
        public void GetRetrieveNotificationsFromACustomerResponse()
        {
            var request = "cus_000006258699";

            var result = _asaasService.GetRetrieveNotificationsFromACustomer(request);

            result.Should().NotBeNull();
        }


    }
}
