using System.Globalization;

namespace oehen.arguard;

// ReSharper disable once InconsistentNaming
public class ExceptionMessageResourceManagerTest
{
    [Theory]
    [InlineData("")]
    [InlineData("de")]
    [InlineData("de-CH")]
    [InlineData("en-US")]
    [InlineData("fr")]
    [InlineData("fr-FR")]
    [InlineData("sq-AL")]
    public void GetMessage_ForAllKey_WithDifferentCultures_MessageShouldNeverBeEmpty(string cultureName)
    {
        if (!string.IsNullOrEmpty(cultureName))
        {
            CultureInfo.CurrentCulture = new CultureInfo(cultureName);
        }

        var keys = ArgumentExceptionMessageResourceManager.GetAllKeys();
        foreach (var key in keys)
        {
            var locMessage = ArgumentExceptionMessageResourceManager.GetMessage(key);
            locMessage.ShouldNotBeNullOrEmpty();
        }
    }
}