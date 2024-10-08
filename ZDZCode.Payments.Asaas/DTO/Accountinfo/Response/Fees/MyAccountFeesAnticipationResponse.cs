using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesAnticipationResponse
    {
        public MyAccountFeesAnticipationCreditCardResponse CreditCard { get; set; }
        public MyAccountFeesAnticipationBankSlipResponse BankSlip { get; set; }

    }
}
