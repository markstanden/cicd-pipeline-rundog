namespace Rundog.Acceptance.Tests.Extensions;

public static class PageExtensions
{
    /// <summary>
    /// Navigates to the specified URL and waits for the page to be fully loaded (network idle).
    /// Useful for Blazor applications where async operations are performed after initial load.
    /// </summary>
    /// <param name="page">The Playwright page instance</param>
    /// <param name="url">The URL to navigate to</param>
    /// <param name="options">Optional navigation options</param>
    /// <returns>The response from the navigation</returns>
    public static async Task<IResponse?> LoadAsync(this IPage page, string url, PageGotoOptions? options = null)
    {
        IResponse? response = await page.GotoAsync(url, options);

        await page.GetByTestId(TestIds.Site.LoadingIndicator)
            .WaitForAsync(new LocatorWaitForOptions { State = WaitForSelectorState.Hidden });

        await page.GetByTestId(TestIds.Main.Section)
            .WaitForAsync(new LocatorWaitForOptions { State = WaitForSelectorState.Visible });

        return response;
    }
}
