using Domain.Exceptions;
using Domain.ValueObjects;
using NUnit.Framework;

namespace Domain.UnitTests.ValueObjects;

public class ColourTests
{
    [Test]
    public void ShouldReturnCorrectColourCode()
    {
        const string code = "#FFFFFF";

        var color = Color.From(code);

        StringAssert.AreEqualIgnoringCase(color, code, $"Цвета {color} и {code} не равны");
    }

    [Test]
    public void ToStringReturnsCode()
    {
        var color = Color.White;

        StringAssert.AreEqualIgnoringCase(color, color.Code, 
            $"Цвета {color} и {color.Code} не равны");
    }

    [Test]
    public void ShouldPerformImplicitConversionToColourCodeString()
    {
        string code = Color.White;

        StringAssert.AreEqualIgnoringCase(code, "#FFFFFF", 
            $"Цвета {code} и #FFFFFF не равны");
    }

    [Test]
    public void ShouldPerformExplicitConversionGivenSupportedColourCode()
    {
        var color = (Color)"#FFFFFF";
        
        Assert.That(color, Is.EqualTo(Color.White), $"Цвета {color} и {Color.White} не равны");
    }

    [Test]
    public void ShouldThrowUnsupportedColourExceptionGivenNotSupportedColourCode()
    {
        Assert.Throws<UnsupportedColourException>(()=> Color.From("##12345"), 
            "Исключение неправильного цвета не вызвано");
    }
}