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
public class HeaderHealthChecks: PageTest
{
    private readonly string _pageUrl = BaseUrl.Value;

    [Fact]
    public async Task Header_Displays_LinksSection()
    {
        // Arrange
        const string testId = TestIds.Header.LinksSection;

        // Act
        await Page.LoadAsync(_pageUrl);
        ILocator element = Page.GetByTestId(testId);

        // Assert
        await Expect(element).ToBeVisibleAsync();
    }

    [Theory]
    [InlineData("github", "github.com")]
    // [InlineData("linkedin", "linkedin.com")]
    public async Task Header_Contains_ExpectedLink(string expectedLinkText, string expectedHref)
    {
        // Arrange
        const string testId = TestIds.Header.LinksSection;

        // Act
        await Page.LoadAsync(_pageUrl);
        ILocator headerLinks = Page.GetByTestId(testId);
        ILocator anchorElements = headerLinks.Locator("a");
        IReadOnlyList<ILocator> anchors = await anchorElements.AllAsync();

        // Assert
        anchors.ShouldNotBeEmpty("No links found");
        List<(string? text, string? href)> anchorTextPairs = new();
        foreach (ILocator anchor in anchors)
        {
            string? text = await anchor.TextContentAsync();
            string? href = await anchor.GetAttributeAsync("href");
            anchorTextPairs.Add((text, href));
        }

        (string? text, string? href) matchingPair = anchorTextPairs
            .FirstOrDefault(pair => pair.text?.Contains(expectedLinkText) ?? false);
        matchingPair.text.ShouldNotBeNullOrWhiteSpace(
            $"Could not find a header link with text containing '{expectedLinkText}'");

        matchingPair.href.ShouldNotBeNullOrWhiteSpace();
        matchingPair.href.ShouldContain(expectedHref);
    }

}
