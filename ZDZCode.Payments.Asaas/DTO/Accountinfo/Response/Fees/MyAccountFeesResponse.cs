using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesResponse
    {

        public MyAccountFeesPaymentResponse Payment { get; set; }
        public MyAccountFeesTransferResponse Transfer { get; set; }
        public MyAccountFeesNotificationResponse Notification { get; set; }
        public MyAccountFeesCreditBureauReportResponse CreditBureauReport { get; set; }
        public MyAccountFeesInvoiceResponse Invoice { get; set; }
        public MyAccountFeesAnticipationResponse Anticipation { get; set; }

    }
}
