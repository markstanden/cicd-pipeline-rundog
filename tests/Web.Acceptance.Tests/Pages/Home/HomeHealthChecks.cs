using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;
using Rundog.Acceptance.Tests.EnvironmentVariables;
using Rundog.Acceptance.Tests.Extensions;
using Rundog.Core.Constants;
using Shouldly;

namespace Rundog.Acceptance.Tests.Pages.Home;

/// <summary>
/// Passive health check type checks used in both staging and production environments to validate that
/// the expected information is displayed on the screen and is not empty.
/// </summary>
[Trait("Environment", "Production")]
public class HomeHealthChecks : PageTest
{
    private readonly string _pageUrl = BaseUrl.Value;

    [Fact]
    public async Task Homepage_Sets_NonEmptyPageTitle()
    {
        // Arrange
        const string expected = Site.Title;

        // Act
        await Page.LoadAsync(_pageUrl);

        // Assert
        expected.ShouldNotBeNullOrWhiteSpace();
        await Expect(Page).ToHaveTitleAsync(expected);
    }

    [Fact]
    public async Task Homepage_Displays_HeaderSection()
    {
        // Arrange
        const string testId = TestIds.Header.Section;

        // Act
        await Page.LoadAsync(_pageUrl);
        ILocator section = Page.GetByTestId(testId);

        // Assert
        await Expect(section).ToBeVisibleAsync();
    }

    [Fact]
    public async Task Homepage_Displays_HeroSection()
    {
        // Arrange
        const string testId = TestIds.Hero.Section;

        // Act
        await Page.LoadAsync(_pageUrl);
        ILocator section = Page.GetByTestId(testId);

        // Assert
        await Expect(section).ToBeVisibleAsync();
    }

    [Fact]
    public async Task Homepage_Displays_FooterSection()
    {
        // Arrange
        const string testId = TestIds.Footer.Section;

        // Act
        await Page.LoadAsync(_pageUrl);
        ILocator section = Page.GetByTestId(testId);

        // Assert
        await Expect(section).ToBeVisibleAsync();
    }
}
