using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesPaymentResponse
    {

        public MyAccountFeesBankSlipResponse BankSlip { get; set; }
        public MyAccountFeesCreditCardResponse CreditCard { get; set; }
        public MyAccountFeesDebitCardResponse DebitCard { get; set; }
        public MyAccountFeesPixResponse Pix { get; set; }

    }
}
