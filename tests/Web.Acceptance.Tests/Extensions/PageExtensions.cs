using Microsoft.Playwright;

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
    public async static Task<IResponse?> LoadAsync(this IPage page, string url, PageGotoOptions? options = null)
    {
        IResponse? response = await page.GotoAsync(url, options);
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        await page.WaitForSelectorAsync($"[data-testid='{TestIds.Main.Section}']");
        return response;
    }
}
