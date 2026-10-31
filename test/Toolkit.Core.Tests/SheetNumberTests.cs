using Toolkit.Core;
using Xunit;

namespace Toolkit.Core.Tests;

public class SheetNumberTests
{
    [Fact]
    public void IsValid_ReturnsTrue_ForNormalNumber()
    {
        Assert.True(SheetNumber.IsValid("A-101"));
    }

    [Fact]
    public void IsValid_ReturnsFalse_ForEmptyText()
    {
        Assert.False(SheetNumber.IsValid(""));

    }

    [Fact]
    public void IsValid_ReturnsFalse_WhenNumberContainsColon()
    {
        Assert.False(SheetNumber.IsValid("A:101"));

    }

}