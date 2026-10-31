namespace Toolkit.Core;

public static class SheetNumber
{
    private static readonly char[] ForbiddenChars =
        { '\\', ':', '{', '}', '[', ']', '|', ';', '<', '>', '?', '`', '~' };

    public static bool IsValid(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        return value.IndexOfAny(ForbiddenChars) == -1;
    }
}