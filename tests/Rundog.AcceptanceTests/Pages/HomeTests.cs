using System.Text.RegularExpressions;
using Microsoft.Playwright.Xunit;
using Rundog.AcceptanceTests.Constants;

namespace Rundog.AcceptanceTests.Pages;

[Trait("Environment", "Production")]
public class HomeTests : PageTest
{
    [Fact]
    public async Task HasTitle()
    {
        // Arrange
        const string expectedSubstring = "Home";
        Regex expectedTitle = new(expectedSubstring);
        string pageUrl = BaseUrl.Value;

        // Act
        await Page.GotoAsync(pageUrl);

        // Assert
        await Expect(Page).ToHaveTitleAsync(expectedTitle);
    }
}
