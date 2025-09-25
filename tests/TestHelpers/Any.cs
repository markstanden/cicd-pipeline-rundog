using System;

namespace TestHelpers;

public static class Any
{
    // Strings
    public const string SingleChar = "a";
    public const string SingleCharUpper = "A";
    public const string SingleDigit = "1";
    public const string SingleUrlUnsafeSymbol = "?";
    public const string SingleUrlSafeSymbol = "_";

    public const string ShortString = "_Any_ String!";
    public const string MediumString = "_Medium_ string with MIXED casing and whitespace";

    public const string LongString =
        "_Long_ string with *MIXED* casing, punctuation, whitespace _and_ even a little markdown too!";

    public const string LowercaseString = "lowercase";
    public const string UppercaseString = "UPPERCASE";
    public const string MixedCaseString = "MiXeDcAsE";
    public const string FourCharString = "abcd";
    public const string FiveCharString = "abcde";
    public const string SixCharString = "abcdef";

    public const string NumbersOnlyString = "123456";

    public const string ShortAlphanumericString = "ABC12345";
    public const string LongAlphanumericString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

    public const string ShortAlphaWithSpecialCharsString = "$A^B*C(D)&1<2>3?4%";
    public const string LongAlphaWithSpecialCharsString = "$-A^B*C(D)&*£!<>|,.?;:@'~#[]{}-_-+1=`3¬%";

    public const string EmailString = "emailstring@domain.com";
    public const string EmailStringWithPlus = "email+string@domain.com";

    public const string UrlString = "https://www.anydomain.com";
    public const string OtherUrlString = "https://www.anotherdomain.com";

    public const string PathString = "path/to/file.txt";

    // Null, empty, and whitespace strings
    public const string NullString = null!;
    public const string EmptyString = "";
    public const string WhitespaceString = "    ";
    public const string NewlineString = "\n";
    public const string CarriageReturnString = "\r";
    public const string CarriageReturnNewlineString = "\r\n";
    public const string TabString = "\t";

    // Numbers
    public const int WholeNumber = 1;

    // URIs
    public static readonly Uri Url = new(UrlString);
    public static readonly Uri OtherUrl = new(OtherUrlString);

    // Dates
    public static readonly DateTime UtcDate = new(2025, 8, 31, 0, 0, 0, DateTimeKind.Utc);
    public static readonly DateTime UtcLeapYear = new(2024, 2, 29, 0, 0, 0, DateTimeKind.Utc);
}
