using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesDebitCardResponse
    {

        public double OperationValue { get; set; }
        public double DefaultPercentage { get; set; }
        public int DaysToReceive { get; set; }

    }
}
