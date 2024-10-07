using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.ValueObject
{
    public record Notification(decimal PhoneCallFeeValue, 
        decimal WhatsAppFeeValue, 
        decimal MessagingFeeValue);    
}
