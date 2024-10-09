using AutoFixture;
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
    }
}
