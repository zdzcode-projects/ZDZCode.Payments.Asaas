using FluentAssertions;
using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Tests.Common;

namespace ZDZCode.Payments.Asaas.Tests
{
    public partial class AsaasServiceTests : BaseAsaasServiceTest
    {
        [Fact]
        public async Task GetMyAccountCommercialInfo()
        {
            var result = await _asaasService.GetMyAccountCommercialInfo();

            result.Should().NotBeNull();
        }

        [Fact]

        public async Task GetMyRetrieveAssasAccountNumber()
        {
            var result = await _asaasService.GetRetrieveAssasAccountNumber();

            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetRetrieveBusinessData()
        {
            var result = await _asaasService.GetRetrieveBusinessDataResponse();

        }

        [Fact]
        public async Task GetMyAccountAccountNumber()
        {

            var result = await _asaasService.GetMyAccountAccountNumber();
 
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetRetrievePersonalizationSettings()
        {    
            var result = await _asaasService.GetRetrievePersonalizationSettingsResponse();

            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetCheckAccountRegistrationStatus()
        {
            var result = await _asaasService.GetCheckAccountRegistrationStatus();

        }

        [Fact]
        public async Task GetMyAccountPaymentCheckoutConfig()
        {
            var result = await _asaasService.GetMyAccountPaymentCheckoutConfig();
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetMyAccountFees()
        {
            var result = await _asaasService.GetMyAccountFees();
            result.Should().NotBeNull();
        }

        [Fact]  
        public async Task GetRetrieveAccountFeesResponse()
        {
            var result = await _asaasService.GetRetrieveAccountFeesResponse();

            result.Should().NotBeNull();
        }
    }
}
