namespace TestHelpers.Theory;

[ExcludeFromCodeCoverage]
public static class TestData
{
    /// <summary>
    ///     Theory data for null, empty, and whitespace strings.
    ///     Used to test null, empty, and whitespace input validation.
    /// </summary>
    /// <example>
    ///     <code>
    /// [Theory]
    /// [MemberData(nameof(TestData.NullOrWhitespace), MemberType = typeof(TestData))]
    /// public void Method_WithEmptyInputString_DoesSomething(string whitespaceString)
    /// {
    ///     // Arrange
    ///     // Act
    ///     // Assert
    /// }
    /// </code>
    /// </example>
    public static readonly TheoryData<string> NullOrWhitespace =
    [
        Any.NullString,
        Any.EmptyString,
        Any.WhitespaceString,
        Any.NewlineString,
        Any.CarriageReturnString,
        Any.CarriageReturnNewlineString,
        Any.TabString
    ];

    /// <summary>
    ///     Theory data for all string variations.
    ///     Uses constants from Any class for consistency and maintainability.
    ///     Strings contain a range from single character to long strings,
    ///     with mixed case, numerics, and special characters
    /// </summary>
    /// <example>
    ///     <code>
    /// [Theory]
    /// [MemberData(nameof(TestData.AlphanumericStringsWithSpecials), MemberType = typeof(TestData))]
    /// public void Method_WithValidInputString_DoesSomething(string validString)
    /// {
    ///     // Arrange
    ///     // Act
    ///     // Assert
    /// }
    ///     </code>
    /// </example>
    public static readonly TheoryData<string> AlphanumericStringsWithSpecials =
    [
        // Single characters
        Any.SingleChar,
        Any.SingleCharUpper,
        Any.SingleDigit,
        Any.SingleUrlSafeSymbol,
        Any.SingleUrlUnsafeSymbol,

        // Various lengths and patterns
        Any.FourCharString,
        Any.FiveCharString,
        Any.SixCharString,
        Any.ShortString,
        Any.MediumString,
        Any.LongString,
        Any.ShortAlphanumericString,
        Any.LongAlphanumericString,

        // Special characters
        Any.ShortAlphaWithSpecialCharsString,
        Any.LongAlphaWithSpecialCharsString,
        Any.EmailString,
        Any.UrlString,
        Any.PathString
    ];

    /// <summary>
    ///     Theory data for clean strings without special characters.
    ///     Useful for testing when the sut expects only alphanumeric input.
    /// </summary>
    public static readonly TheoryData<string> AlphanumericStringsOnly =
    [
        Any.SingleChar,
        Any.SingleCharUpper,
        Any.SingleDigit,
        Any.LowercaseString,
        Any.UppercaseString,
        Any.MixedCaseString,
        Any.NumbersOnlyString,
        Any.ShortAlphanumericString,
        Any.LongAlphanumericString
    ];

    /// <summary>
    ///     Theory data for strings with URL-safe characters only.
    ///     Contains letters, numbers, hyphens, underscores, full-stops, tildes.
    /// </summary>
    public static readonly TheoryData<string> UrlSafeStrings =
    [
        Any.SingleChar,
        Any.SingleCharUpper,
        Any.SingleDigit,
        Any.SingleUrlSafeSymbol,
        Any.FourCharString,
        Any.LowercaseString,
        Any.UppercaseString,
        Any.MixedCaseString,
        Any.NumbersOnlyString,
        Any.ShortAlphanumericString,
        Any.LongAlphanumericString,
        Any.PathString
    ];

    /// <summary>
    ///     Theory data for strings containing characters that require URL encoding.
    ///     Contains spaces, special symbols, and other non-URL-safe characters.
    ///     Used to test escaping string inputs in validation methods
    /// </summary>
    public static readonly TheoryData<string> NonUrlSafeStrings =
    [
        // Intentionally unsafe
        Any.SingleUrlUnsafeSymbol,
        Any.ShortAlphaWithSpecialCharsString,
        Any.LongAlphaWithSpecialCharsString,

        // Spaces and markdown
        Any.ShortString,
        Any.MediumString,
        Any.LongString,

        // @
        Any.EmailString,
        Any.EmailStringWithPlus
    ];
}
