using System.Text.RegularExpressions;
using Microsoft.Playwright.Xunit;
using rundog.E2E.Tests.Constants;

namespace rundog.E2E.Tests.Pages;

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
