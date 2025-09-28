namespace Rundog.Core.Models;

/// <summary>
/// Represents a hyperlink anchor with
/// display text and URL reference.
/// </summary>
public record Link(
    string Text,
    string Href
);
