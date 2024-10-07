using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesBankSlipResponse
    {

        public double DefaultValue { get; set; }
        public double? DiscountValue { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int DaysToReceive { get; set; }

    }
}
