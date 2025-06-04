using ZDZCode.Payments.Asaas.DTO.Transfer.Request;
using ZC.DomainService.HttpClientCore;
using FluentAssertions;

namespace ZDZCode.Payments.Asaas.Tests
{
    public partial class AsaasServiceTests
    {
        [Fact]
        public void CreateTransfer()
        {
            var request = new TransferRequest
            {
                WalletId = "wallet_123",
                Value = 10,
                Description = "test"
            };

            var result = _asaasService.CreateTransfer(request);
            result.Should().NotBeNull();
        }

        [Fact]
        public void ListTransfers()
        {
            var result = _asaasService.ListTransfers();
            result.Should().NotBeNull();
        }

        [Fact]
        public void GetTransferById()
        {
            var result = _asaasService.GetTransferById("trf_123");
            result.Should().NotBeNull();
        }
    }
}
