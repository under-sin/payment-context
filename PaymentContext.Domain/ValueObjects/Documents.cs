using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Documents : ValueObject
{
    public Documents(string number, EDocumentType type)
    {
        Number = number;
        Type = type;
        
        AddNotifications(new Contract<Documents>()
            .Requires()
            .IsTrue(Validate(), "Document.Number", "Documento inválido")
        );
    }

    public string Number { get; private set; }
    public EDocumentType Type { get; private set; }

    private bool Validate()
    {
        switch (Type)
        {
            case EDocumentType.CNPJ when Number.Length == 14:
            case EDocumentType.CPF when Number.Length == 11:
                return true;
            default:
                return false;
        }
    }
}