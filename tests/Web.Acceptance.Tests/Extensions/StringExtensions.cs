namespace Rundog.Acceptance.Tests.Extensions;

public static class StringExtensions
{
    /// <summary>
    /// Counts the number of times a substring appears in the source string
    /// and asserts that it matches the expected count.
    /// </summary>
    /// <param name="source">The string to search.</param>
    /// <param name="substring">The substring to search for and count</param>
    /// <param name="times">The expected number of times the substring should occur</param>
    public static void ShouldOccur(this string source, string substring, int times)
    {
        ArgumentException.ThrowIfNullOrEmpty(source);
        ArgumentException.ThrowIfNullOrEmpty(substring);

        int occurrenceCount = source.Split(substring).Length - 1;
        occurrenceCount.ShouldBe(times);
    }

    /// <summary>
    /// Asserts that the specified substring occurs exactly once in the source string.
    /// </summary>
    /// <param name="source">The string to search</param>
    /// <param name="substring">The substring to search for and count</param>
    public static void ShouldOccurOnce(this string source, string substring)
        => source.ShouldOccur(substring, 1);

}
