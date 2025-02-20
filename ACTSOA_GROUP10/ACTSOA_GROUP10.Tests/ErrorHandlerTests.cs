using Xunit;
using System;
using ACTSOA_GROUP10.CommonLayer.Utilities;

public class ErrorHandlerTests
{
    [Fact]
    public void GetErrorMessage_ShouldReturnCorrectMessage()
    {
        var exception = new Exception("Test error");
        string message = ErrorHandler.GetErrorMessage(exception);
        Assert.Equal("Test error", message);
    }
}
