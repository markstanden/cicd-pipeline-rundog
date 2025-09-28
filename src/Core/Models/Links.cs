namespace Rundog.Core.Models;

/// <summary>
/// Represents a hyperlink anchor with
/// display text and URL reference.
/// </summary>
/// <param name="Text">The text description for the Link, output to the rendered page</param>
/// <param name="Href">The URL to follow when clicked</param>

public record Link(
    string Text,
    string Href
);
