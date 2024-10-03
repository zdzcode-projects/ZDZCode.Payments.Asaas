using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
