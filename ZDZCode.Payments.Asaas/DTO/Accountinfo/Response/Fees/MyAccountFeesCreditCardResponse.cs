using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.DTO.Accountinfo.Response.Fees
{
    public class MyAccountFeesCreditCardResponse
    {

        public double OperationValue { get; set; }
        public double OneInstallmentPercentage { get; set; }
        public double UpToSixInstallmentsPercentage { get; set; }
        public double UpToTwelveInstallmentsPercentage { get; set; }
        public double? DiscountOneInstallmentPercentage { get; set; }
        public double? DiscountUpToSixInstallmentsPercentage { get; set; }
        public double? DiscountUpToTwelveInstallmentsPercentage { get; set; }
        public DateTime? DiscountExpiration { get; set; }
        public int DaysToReceive { get; set; }
        public bool HasValidDiscount { get; set; }

    }
}
