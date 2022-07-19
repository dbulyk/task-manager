namespace Domain.Exceptions;

public class UnsupportedColourException : Exception
{
    public UnsupportedColourException(string code)
        : base($"Цвет \"{code}\" не поддерживается.")
    {
    }
}