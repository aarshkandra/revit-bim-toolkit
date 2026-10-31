namespace Toolkit.Core;

public static class SheetNumber
{

    private static readonly char[] ForbiddenChars =
    {
        '\\', ':', '{', '}', '[', ']', '|', ';', '<', '>', '?', '`', '~'
    };

    public static bool IsValid(string? value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }
}