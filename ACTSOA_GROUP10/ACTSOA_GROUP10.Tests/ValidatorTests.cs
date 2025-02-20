using Xunit;
using ACTSOA_GROUP10.CommonLayer.Utilities;

public class ValidatorTests
{
    [Theory]
    [InlineData("test@example.com", true)]
    [InlineData("invalid-email", false)]
    public void IsValidEmail_ShouldReturnCorrectResult(string email, bool expected)
    {
        bool result = Validator.IsValidEmail(email);
        Assert.Equal(expected, result);
    }
}
