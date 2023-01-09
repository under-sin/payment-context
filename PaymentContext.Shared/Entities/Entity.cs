using Flunt.Notifications;

namespace PaymentContext.Shared.Entities;

public abstract class Entity : Notifiable<Notification>
{
    public Entity(Guid id)
    {
        Id = Guid.NewGuid();
    }

    protected Entity()
    {
        throw new NotImplementedException();
    }

    public Guid Id { get; private set; }
}