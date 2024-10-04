using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.Payments.Asaas.ValueObject
{
    public record Discount
    {
        public decimal Value { get; set; }

        public int DueDateLimitDays { get; set; }

        public Type Type { get; set; }

    }
}
