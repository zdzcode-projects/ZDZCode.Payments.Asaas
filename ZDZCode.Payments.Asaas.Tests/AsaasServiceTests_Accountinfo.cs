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

            result.Should().NotBeNull();
        }
    }
}
