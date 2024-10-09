using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesPixTransferResponse
    {

        public double FeeValue { get; set; }
        public double? DiscountValue { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool ConsideredInMonthlyTransfersWithoutFee { get; set; }

    }
}
