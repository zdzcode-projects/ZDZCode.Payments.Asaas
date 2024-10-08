using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesPixResponse
    {

        public double? FixedFeeValue { get; set; }
        public double? FixedFeeValueWithDiscount { get; set; }
        public double? PercentageFee { get; set; }
        public double? MinimumFeeValue { get; set; }
        public double? MaximumFeeValue { get; set; }
        public DateTime? DiscountExpiration { get; set; }
        public int MonthlyCreditsWithoutFee { get; set; }
        public int CreditsReceivedOfCurrentMonth { get; set; }
        public string Type { get; set; }

    }
}
