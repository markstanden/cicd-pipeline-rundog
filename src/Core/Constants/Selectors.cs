namespace Rundog.Core.Constants;

/// <summary>
/// Constant values related to CSS selectors used within the application.
/// </summary>
public static class Selectors
{
    /// <summary>
    /// Provides constant values for page initial focus functionality.
    /// </summary>
    public static class InitialFocus
    {
        /// <summary>
        /// The default element ID used for the initial focus element within a page.
        /// </summary>
        public const string Id = "initial-focus";

        /// <summary>
        /// Data attribute name which, if present on the page, overrides the default element.
        /// </summary>
        public const string DataOverride = "data-initial-focus";

        /// <summary>
        /// Combined selector that prefers a page override and falls back to the default element.
        /// </summary>
        public const string Selector = $"[{DataOverride}], #{Id}";
    }
}
