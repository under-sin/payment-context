using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Test.ValueObjects;

[TestClass]
public class DocumentTests
{
    // Red, Green, Refactor
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
        var doc = new Documents("123", EDocumentType.CNPJ);
        Assert.IsFalse(doc.IsValid);
    }
    
    [TestMethod]
    public void ShouldReturnSuccessWhenCNPJIsValid()
    {
        var doc = new Documents("78841284000136", EDocumentType.CNPJ);
        Assert.IsTrue(doc.IsValid);
    }
    
    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
        var doc = new Documents("123", EDocumentType.CPF);
        Assert.IsFalse(doc.IsValid);
    }
    
    [TestMethod]
    public void ShouldReturnSuccessWhenCPFIsValid()
    {
        var doc = new Documents("39227361065", EDocumentType.CPF);
        Assert.IsTrue(doc.IsValid);
    }
}