namespace Rundog.Core.EnvironmentVariables;

/// <summary>
///     Provides the base URL for the application, either retrieved from an environment variable
///     or defaulting to a predefined local value if the environment variable is not set.
/// </summary>
public static class BaseUrl
{
    private const string BaseUrlEnvironmentVariable = "BASE_URL";
    private const string BaseUrlDefaultLocalValue = "http://localhost:5163";

    /// <summary>
    ///     Gets the base URL for tests from the BASE_URL environment variable.
    ///     defaults to <see cref="BaseUrlDefaultLocalValue" />: http://localhost:5163.
    /// </summary>
    public static string Value
    {
        get
        {
            string? raw = Environment.GetEnvironmentVariable(BaseUrlEnvironmentVariable);
            return string.IsNullOrWhiteSpace(raw) ? BaseUrlDefaultLocalValue : raw.Trim();
        }
    }
}
