namespace Rundog.Core.Constants;

/// <summary>
/// A collection of constant test handles used throughout the application for testing purposes.
/// </summary>
public static class TestIds
{
    /// <summary>
    /// Site global elements
    /// </summary>
    public static class Site
    {
        /// <summary>
        /// The main title of the Site.
        /// Displayed in the tab within the browser
        /// </summary>
        public const string Title = "site-title";

        /// <summary>
        /// The identifier for the loading indicator element used in testing.
        /// </summary>
        public const string LoadingIndicator = "loading-indicator";
    }

    /// <summary>
    /// Test handles for elements within the header section.
    /// </summary>
    public static class Header
    {
        /// <summary>
        /// The identifier for the header section
        /// </summary>
        public const string Section = "header-section";

        /// <summary>
        /// The identifier for the logo section within the header
        /// </summary>
        public const string LogoSection = "header-logo-section";

        /// <summary>
        /// The identifier for the links section within the header
        /// </summary>
        public const string LinksSection = "header-links-section";
    }

    /// <summary>
    /// Test handles for elements within the main content section.
    /// </summary>
    public static class Main
    {
        /// <summary>
        /// The identifier for the main content section used in testing.
        /// </summary>
        public const string Section = "main-section";
    }

    /// <summary>
    /// Test handles for elements within the footer section.
    /// </summary>
    public static class Footer
    {
        /// <summary>
        /// The identifier for the footer section used in testing.
        /// </summary>
        public const string Section = "footer-section";
    }

    /// <summary>
    /// Test handles for elements within the developer Hero
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

    /// <summary>
    /// Test handles for elements within the command decoration section.
    /// </summary>
    public static class CommandDecoration
    {
        /// <summary>
        /// The identifier for command decoration in the logo section
        /// </summary>
        public const string Logo = "command-logo";

        /// <summary>
        /// The identifier for command decoration in the links section
        /// </summary>
        public const string Links = "command-links";

        /// <summary>
        /// The identifier for command decoration in the hero section
        /// </summary>
        public const string HeroSection = "command-hero";

        /// <summary>
        /// The identifier for command decoration for the name in the hero section
        /// </summary>
        public const string Name = "command-name";

        /// <summary>
        /// The identifier for command decoration for the motto in the hero section
        /// </summary>
        public const string Slogan = "command-motto";

        /// <summary>
        /// The identifier for command decoration for the description in the hero section
        /// </summary>
        public const string Intro = "command-description";
    }
}
