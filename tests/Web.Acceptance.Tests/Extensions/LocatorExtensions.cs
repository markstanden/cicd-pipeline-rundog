using System.Text.RegularExpressions;

namespace Rundog.Acceptance.Tests.Extensions;

/// <summary>
/// Extension methods for Playwright ILocator to simplify common test operations.
/// </summary>
public static partial class LocatorExtensions
{
    /// <summary>
    /// Regular expression to validate that a string contains only characters used within valid JavaScript identifiers.
    /// </summary>
    [GeneratedRegex(@"^[a-zA-Z_$][a-zA-Z0-9_$]*$")]
    private static partial Regex HasValidJsPropertyChars();

    /// <summary>
    /// Retrieves the computed style value of a specified CSS property for a given locator.
    /// </summary>
    /// <param name="locator">The locator representing the DOM element.</param>
    /// <param name="jsPropertyName">The CSS property name (in JS notation) to retrieve.</param>
    /// <returns>A task that resolves to the value of the specified CSS property as a string.</returns>
    /// <throws cref="ArgumentException">Thrown if the property name is not a valid JavaScript identifier.</throws>
    public async static Task<string> GetComputedStyleAsync(this ILocator locator, string jsPropertyName)
    {
        // Validate jsPropertyName contains only valid JS identifier characters
        if (!HasValidJsPropertyChars().IsMatch(jsPropertyName))
        {
            throw new ArgumentException(
                "Property name must be a valid JavaScript identifier",
                nameof(jsPropertyName));
        }

        return await locator.EvaluateAsync<string>($"element => getComputedStyle(element).{jsPropertyName}");
    }


}
