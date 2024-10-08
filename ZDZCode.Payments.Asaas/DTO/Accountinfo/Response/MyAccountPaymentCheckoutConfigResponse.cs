using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response
{
    public class MyAccountPaymentCheckoutConfigResponse
    {

        public string Object { get; set; }
        public string LogoBackgroundColor { get; set; } 
        public string InfoBackgroundColor { get; set; }
        public string FontColor { get; set; }
        public bool Enabled { get; set; } = true;
        public string LogoUrl { get; set; }
        public string Observations { get; set; }
        public string Status { get; set; }

    }
}
