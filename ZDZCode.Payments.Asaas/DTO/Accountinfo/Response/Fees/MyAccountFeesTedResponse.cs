using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesTedResponse
    {
        public double FeeValue { get; set; }
        public bool ConsideredInMonthlyTransfersWithoutFee { get; set; }
    }
}
