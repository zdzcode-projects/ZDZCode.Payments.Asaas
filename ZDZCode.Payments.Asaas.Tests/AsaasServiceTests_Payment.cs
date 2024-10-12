using AutoFixture;
using FluentAssertions;
using ZDZCode.Payments.Asaas.DTO.Payment.Request;

namespace ZDZCode.Payments.Asaas.Tests
{
    public partial class AsaasServiceTests
    {
        [Fact] 
        public void CreateNewPayment()
        {
            var request = _fixture
                  .Build<CreateNewPaymentRequest>()
                  .Create();

            var result =  _asaasService.CreateNewPayment(request);

            Assert.NotNull(result);
        }

        [Fact]

        public void CreateNewPaymentWithSummaryData()
        {
            var request = _fixture
                .Build<CreateNewPaymentRequest>()
                .Create();

            var result = _asaasService.CreateNewPaymentWithSummaryData(request);

           Assert.NotNull(result);

        }

        [Fact]
        public void GetListPayments()
        {
            var result = _asaasService.GetListPayments();

            result.Should().NotBeNull();
            
        }

        [Fact]
        public void GetListPaymentsSummaryData()
        {
            var result = _asaasService.GetListPaymentsWithSummaryData();

            result.Should().NotBeNull();
        }
    }
}
