﻿using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class CreditCardPayment : Payment
{
    public CreditCardPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer,
        Documents documents, Address address, Email email, string cardHolderName, string cardNumber,
        string lastTransactionNumber) : base(paidDate, expireDate, total, totalPaid, payer, documents, address, email)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionNumber = lastTransactionNumber;
    }

    public string CardHolderName { get; private set; }
    public string CardNumber { get; private set; }
    public string LastTransactionNumber { get; private set; }
}