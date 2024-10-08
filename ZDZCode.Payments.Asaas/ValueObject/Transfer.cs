

using Newtonsoft.Json;
using System.Text.Json.Serialization;
using ZDZCode.Payments.Asaas.Commum;

namespace ZDZCode.Payments.Asaas.ValueObject
{
    public class Transfer
    {
        public int MonthlyTransfersWithoutFee { get; set; }
        public Ted Ted { get; set; }       
        public PixTransfer Pix { get; set; }
    }
}
