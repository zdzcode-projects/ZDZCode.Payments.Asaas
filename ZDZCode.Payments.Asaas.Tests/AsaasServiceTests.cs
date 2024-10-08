using AutoFixture;
using ZC.DomainService.HttpClientCore;

using ZDZCode.Payments.Asaas.Tests.Common;

namespace ZDZCode.Payments.Asaas.Tests
{
    public partial class AsaasServiceTests : BaseAsaasServiceTest
    {

        private readonly Fixture _fixture = new();
        public AsaasServiceTests(AsaasService asaasService) : base(asaasService)
        {
                  

        }  

    }
}
