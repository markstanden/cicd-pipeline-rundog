using System.Text.RegularExpressions;

namespace Rundog.Acceptance.Tests.Pages.Home;

public class ThemeTests : PageTest
{
    private readonly string _pageUrl = BaseUrl.Value;

    private Task EmulateDarkModeAsync()
        => Page.EmulateMediaAsync(new PageEmulateMediaOptions { ColorScheme = ColorScheme.Dark });
    private Task EmulateLightModeAsync()
        => Page.EmulateMediaAsync(new PageEmulateMediaOptions { ColorScheme = ColorScheme.Light });

    [Fact]
    public async Task Page_WithLightSystemPreference_HasDarkTextOnLightBackground()
    {
        // Arrange
        await EmulateLightModeAsync();

        // Act
        await Page.LoadAsync(_pageUrl);

        // Assert
        ILocator body = Page.Locator("body");

        string bgColor = await body.GetComputedStyleAsync("backgroundColor");
        string textColor = await body.GetComputedStyleAsync("color");

        int bgBrightness = GetRoughBrightness(bgColor);
        int textBrightness = GetRoughBrightness(textColor);

        textBrightness.ShouldBeLessThan(bgBrightness,
                                           "Text should be darker than background in light mode");
    }

    [Fact]
    public async Task Page_WithDarkSystemPreference_HasLightTextOnDarkBackground()
    {
        // Arrange
        await EmulateDarkModeAsync();

        // Act
        await Page.LoadAsync(_pageUrl);

        // Assert
        ILocator body = Page.Locator("body");

        string bgColor = await body.GetComputedStyleAsync("backgroundColor");
        string textColor = await body.GetComputedStyleAsync("color");

        int bgBrightness = GetRoughBrightness(bgColor);
        int textBrightness = GetRoughBrightness(textColor);

        textBrightness.ShouldBeGreaterThan(bgBrightness,
                                          "Text should be lighter than background in dark mode");
    }

    /// <summary>
    /// Calculates a rough brightness value for an RGB colour string.
    /// </summary>
    /// <param name="rgb">The RGB colour string (e.g., "rgb(255, 255, 255)").</param>
    /// <returns>The sum of the RGB components as an integer.</returns>
    private static int GetRoughBrightness(string rgb)
    {
        MatchCollection matches = Regex.Matches(rgb, @"\d+");
        return matches.Sum(color => int.Parse(color.Value));
    }
}
