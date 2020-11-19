using System;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderName, string carNumber, string lastTransactionNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, string address, string email) : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CarNumber = carNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CarNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}