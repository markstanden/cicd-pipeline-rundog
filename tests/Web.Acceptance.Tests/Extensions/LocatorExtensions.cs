namespace Rundog.Acceptance.Tests.Extensions;

/// <summary>
/// Extension methods for Playwright ILocator to simplify common test operations.
/// </summary>
public static class LocatorExtensions
{
    /// <summary>
    /// Retrieves the computed style value of a specified CSS property for a given locator.
    /// </summary>
    /// <param name="locator">The locator representing the DOM element.</param>
    /// <param name="jsPropertyName">The CSS property name (in JS notation) to retrieve.</param>
    /// <returns>A task that resolves to the value of the specified CSS property as a string.</returns>
    public async static Task<string> GetComputedStyleAsync(this ILocator locator, string jsPropertyName)
    {
        return await locator.EvaluateAsync<string>(
            $"element => getComputedStyle(element).{jsPropertyName}"
        );
    }
}
