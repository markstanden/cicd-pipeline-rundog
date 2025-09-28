namespace Rundog.Core.Constants;

/// <summary>
///     A collection of constant test handles used throughout the application for testing purposes.
/// </summary>
public static class TestIds
{
    /// <summary>
    ///     Site global elements
    /// </summary>
    public static class Site
    {
        /// <summary>
        ///     The main title of the Site.
        ///     Displayed in the tab within the browser
        /// </summary>
        public const string Title = "site-title";
    }

    /// <summary>
    ///     Test handles for elements within the developer Hero
    /// </summary>
    public static class Hero
    {
        /// <summary>
        /// The identifier for the developer hero section used in testing.
        /// </summary>
        public const string Section = "hero-section";

        /// <summary>
        /// The identifier for the developer's name used in testing.
        /// </summary>
        public const string Name = "hero-name";

        /// <summary>
        /// The identifier for the developer's slogan used in testing.
        /// </summary>
        public const string Slogan = "hero-slogan";

        /// <summary>
        /// The identifier for the developer's introduction or brief description used in testing.
        /// </summary>
        public const string Intro = "hero-intro";
    }
}
