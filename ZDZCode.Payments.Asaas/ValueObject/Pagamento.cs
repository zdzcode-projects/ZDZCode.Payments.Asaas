namespace ZDZCode.Payments.Asaas.ValueObject
{
    public class Pagamento
    {
        public BankSlip BankSlip { get; set; }
        public CreditCard CreditCard { get; set; }
        public DebitCard DebitCard { get; set; }
        public Pix Pix { get; set; }
    }
}
