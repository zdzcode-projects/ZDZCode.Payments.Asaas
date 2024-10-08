using AutoFixture;

namespace ZDZCode.Payments.Asaas.Tests.Common
{
    public class BaseAsaasServiceTest
    {
        protected readonly AsaasService _asaasService;        

        public BaseAsaasServiceTest(AsaasService asaasService)
        {
            _asaasService = asaasService;            
        }
    }
}
