using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesTransferResponse
    {

        public int MonthlyTransfersWithoutFee { get; set; }
        public MyAccountFeesTedResponse Ted { get; set; }
        public MyAccountFeesPixTransferResponse Pix { get; set; }

    }
}
