﻿using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories;

public interface IStudenteRepository
{
    bool DocumentExists(string document);
    bool EmailExists(string email);
    void CreateSubscription(Student student);
}