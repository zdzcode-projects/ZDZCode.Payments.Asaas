using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesNotificationResponse
    {

        public double PhoneCallFeeValue { get; set; }
        public double WhatsAppFeeValue { get; set; }
        public double MessagingFeeValue { get; set; }
        public double PostalServiceFeeValue { get; set; }
        public double SmsFeeValue { get; set; }

    }
}
