using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;
using Rundog.Core.Constants;
using Rundog.Core.EnvironmentVariables;

namespace Rundog.AcceptanceTests.Pages;

[Trait("Environment", "Production")]
public class HomeTests : PageTest
{
    private readonly string _pageUrl = BaseUrl.Value;

    [Fact]
    public async Task HasExpectedTitle()
    {
        // Arrange
        const string expectedTitle = Site.Title;

        // Act
        await Page.GotoAsync(_pageUrl);

        // Assert
        await Expect(Page).ToHaveTitleAsync(expectedTitle);
    }

    [Fact]
    public async Task HasExpectedSlogan()
    {
        // Arrange
        const string testId = "site-slogan";
        const string expectedText = Site.Slogan;

        // Act
        await Page.GotoAsync(_pageUrl);
        ILocator sloganElement = Page.GetByTestId(testId);

        // Assert
        await Expect(sloganElement).ToHaveTextAsync(expectedText);
    }
}
