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
        public async Task GetMyAccountAccountNumber()
        {

            var result = await _asaasService.GetMyAccountAccountNumber();
            result.Should().NotBeNull();
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
    }
}
