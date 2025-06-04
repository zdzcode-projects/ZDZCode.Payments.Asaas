using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.PaymentLink.Request;

namespace ZDZCode.Payments.Asaas.Tests
{
    public partial class AsaasServiceTests
    {
        [Fact]
        public void CreatePaymentLink()
        {
            var request = new PaymentLinkRequest
            {
                Name = "Teste",
                Description = "Pagamento teste",
                Value = 10,
                BillingType = "UNDEFINED"
            };

            var result = _asaasService.CreatePaymentLink(request);

            result.Should().NotBeNull();
        }

        [Fact]
        public void GetPaymentLink()
        {
            var result = _asaasService.GetPaymentLink("pl_123");

            result.Should().NotBeNull();
        }

        [Fact]
        public void ListPaymentLinks()
        {
            var result = _asaasService.ListPaymentLinks();

            result.Should().NotBeNull();
        }

        [Fact]
        public void UpdatePaymentLink()
        {
            var request = new PaymentLinkRequest
            {
                Name = "Teste",
                Description = "Pagamento teste",
                Value = 20,
                BillingType = "UNDEFINED"
            };

            var result = _asaasService.UpdatePaymentLink("pl_123", request);

            result.Should().NotBeNull();
        }

        [Fact]
        public void DeletePaymentLink()
        {
            var result = _asaasService.DeletePaymentLink("pl_123");

            result.Should().NotBeNull();
        }
    }
}
