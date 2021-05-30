using System.Globalization;
using FluentAssertions;
using Xunit;

namespace oehen.arguard
{
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
                locMessage.Should().NotBeNullOrEmpty();
            }
        }
    }
}