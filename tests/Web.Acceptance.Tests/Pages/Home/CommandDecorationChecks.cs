namespace Rundog.Acceptance.Tests.Pages.Home;

/// <summary>
/// Passive health check type checks used in both staging and production environments to validate that
/// the expected information is displayed on the screen and is not empty.
/// </summary>
[Trait("Environment", "Production")]
public class CommandDecorationChecks : PageTest
{
    private readonly string _pageUrl = BaseUrl.Value;

    [Theory]
    [InlineData(TestIds.CommandDecoration.Logo, CommandDecorationText.Logo)]
    [InlineData(TestIds.CommandDecoration.Links, CommandDecorationText.Links)]
    public async Task Header_Displays_ExpectedCommandDecorations(string testId, string expectedCommand)
    {
        // Arrange
        const string expectedPrompt = CommandDecorationText.Prompt;
        const string expectedShowFlag = CommandDecorationText.ShowFlag;

        // Act
        await Page.LoadAsync(_pageUrl);
        ILocator element = Page.GetByTestId(testId);

        // Assert
        string text = await element.InnerTextAsync();
        expectedCommand.ShouldNotBeNullOrWhiteSpace();

        text.ShouldOccurOnce(expectedPrompt);
        text.ShouldOccurOnce(expectedCommand);
        text.ShouldOccurOnce(expectedShowFlag);
    }


    [Theory]
    [InlineData(TestIds.CommandDecoration.HeroSection, CommandDecorationText.HeroSection)]
    [InlineData(TestIds.CommandDecoration.Name, CommandDecorationText.Name)]
    [InlineData(TestIds.CommandDecoration.Slogan, CommandDecorationText.Slogan)]
    [InlineData(TestIds.CommandDecoration.Intro, CommandDecorationText.Introduction)]
    public async Task Hero_Displays_ExpectedCommandDecorations(string testId, string expectedCommand)
    {
        // Arrange
        const string expectedPrompt = CommandDecorationText.Prompt;
        const string expectedShowFlag = CommandDecorationText.ShowFlag;

        // Act
        await Page.LoadAsync(_pageUrl);
        ILocator element = Page.GetByTestId(testId);

        // Assert
        string text = await element.InnerTextAsync();
        expectedCommand.ShouldNotBeNullOrWhiteSpace();

        text.ShouldOccurOnce(expectedPrompt);
        text.ShouldOccurOnce(expectedCommand);
        text.ShouldOccurOnce(expectedShowFlag);
    }
}
