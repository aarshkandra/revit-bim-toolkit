using System.Security.Cryptography;
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
}