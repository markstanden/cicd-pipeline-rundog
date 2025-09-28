using Rundog.Core.Models;

namespace Rundog.Core.Constants;

/// <summary>
/// Provides constant definitions for links used within the application.
/// </summary>
public static class Links
{
    /// <summary>
    /// Represents a collection of predefined links displayed in the application's header.
    /// Each link contains a text description and its associated URL.
    /// </summary>
    public static readonly IEnumerable<Link> HeaderLinks =
    [
        new("github", "https://github.com/markstanden"),
        new("linkedin", "https://www.linkedin.com/in/markstanden/")
    ];
}
