using System.Text.RegularExpressions;
using Microsoft.Playwright.Xunit;

namespace rundog.E2E.Tests.Pages;

public class HomeTests : PageTest
{
    [Fact]
    public async Task HasTitle()
    {
        // Arrange
        const string expectedSubstring = "FAILINGTEST";
        Regex expectedTitle = new(expectedSubstring);
        const string pageUrl = "https://playwright.dev";

        // Act
        await Page.GotoAsync(pageUrl);

        // Assert
        await Expect(Page).ToHaveTitleAsync(expectedTitle);
    }
}
