using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;
using Rundog.Acceptance.Tests.EnvironmentVariables;
using Rundog.Acceptance.Tests.Extensions;
using Rundog.Core.Constants;
using Shouldly;

namespace Rundog.Acceptance.Tests.Pages.Home;

/// <summary>
/// Passive healthcheck type checks used in both staging and production environments to validate that
/// the expected information is desplayed on the screen and is not empty.
/// </summary>
[Trait("Environment", "Production")]
public class HeroHealthChecks: PageTest
{
    private readonly string _pageUrl = BaseUrl.Value;

    [Fact]
    public async Task Hero_Displays_NonEmptyDeveloperName()
    {
        // Arrange
        const string testId = TestIds.Hero.Name;
        const string expected = Hero.Name;

        // Act
        await Page.LoadAsync(_pageUrl);
        ILocator element = Page.GetByTestId(testId);

        // Assert
        expected.ShouldNotBeNullOrWhiteSpace();
        await Expect(element).ToHaveTextAsync(expected);
    }

    [Fact]
    public async Task Hero_Displays_NonEmptySlogan()
    {
        // Arrange
        const string testId = TestIds.Hero.Slogan;
        const string expected = Hero.Slogan;

        // Act
        await Page.LoadAsync(_pageUrl);
        ILocator element = Page.GetByTestId(testId);

        // Assert
        expected.ShouldNotBeNullOrWhiteSpace();
        await Expect(element).ToHaveTextAsync(expected);
    }

    [Fact]
    public async Task Hero_Displays_NonEmptyDeveloperIntroduction()
    {
        // Arrange
        const string testId = TestIds.Hero.Intro;
        const string expected = Hero.Introduction;

        // Act
        await Page.LoadAsync(_pageUrl);
        ILocator element = Page.GetByTestId(testId);

        // Assert
        expected.ShouldNotBeNullOrWhiteSpace();
        await Expect(element).ToHaveTextAsync(expected);
    }
}
