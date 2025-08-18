namespace rundog.E2E.Tests.Constants;

public static class BaseUrl
{
    private const string BaseUrlEnvironmentVariable = "BASE_URL";
    private const string BaseUrlDefaultLocalValue = "http://localhost:5163";

    /// <summary>
    ///     Gets the base URL for tests from the BASE_URL environment variable.
    ///     Falls back to localhost for local testing if not set.
    /// </summary>
    public static string Value =>
        Environment.GetEnvironmentVariable(BaseUrlEnvironmentVariable) ?? BaseUrlDefaultLocalValue;
}
