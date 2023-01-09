using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities;

public class Student : Entity
{
    private IList<Subscription> _subscriptions;

    public Student(Name name, Documents documents, Email email)
    {
        Name = name;
        Documents = documents;
        Email = email;
        _subscriptions = new List<Subscription>();
        
        AddNotifications(name, documents, email);
    }

    public Name Name { get; private set; }
    public Documents Documents { get; set; }
    public Email Email { get; private set; }
    public Address Address { get; private set; }
    public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions.ToArray();

    public void AddSubscription(Subscription subscription)
    {
        var hasSubscriptionActive = false;
        foreach (var sub in _subscriptions)
        {
            if (sub.Active)
                hasSubscriptionActive = true;
        }
        
        if (hasSubscriptionActive)
            AddNotification("Student.Subscriptions", "Você já tem uma assinatura");
    }
}