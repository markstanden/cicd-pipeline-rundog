using System.Text.RegularExpressions;
using Microsoft.Playwright.Xunit;

namespace Pages;

public class HomeTests: PageTest
{
    [Fact]
    public async Task HasTitle()
    {
        // Arrange
        const string expectedSubstring = "Playwright";
        Regex expectedTitle = new Regex(expectedSubstring);
        const string pageUrl = "https://playwright.dev";
        
        // Act
        await Page.GotoAsync(pageUrl);

        // Assert
        await Expect(Page).ToHaveTitleAsync(expectedTitle);
    }
}
