using FluentAssertions;
using ZC.DomainService.HttpClientCore;
using ZDZCode.Payments.Asaas.Tests.Common;

namespace ZDZCode.Payments.Asaas.Tests
{
    public partial class AsaasServiceTests
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


        public async Task GetMyAccountAccountNumber()
        {

            var result = await _asaasService.GetMyAccountAccountNumber();

            result.Should().NotBeNull();
        }
    }
}
