namespace Toolkit.Core;

public static class SheetNumber
{
    public static bool IsValid(string? value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }
}