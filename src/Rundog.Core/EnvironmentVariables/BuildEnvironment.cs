namespace Rundog.Core.EnvironmentVariables;

public static class BuildEnvironment
{
    private const string EnvironmentVariable = "BUILD_ENVIRONMENT";
    private const string DefaultLocalValue = "Local";

    /// <summary>
    ///     Represents the current build environment value. Retrieves the value from the
    ///     environment variable "BUILD_ENVIRONMENT". If the environment variable is not set,
    ///     it defaults to <see cref="DefaultLocalValue">DefaultLocalValue</see>: "Local".
    /// </summary>
    public static string Value
    {
        get
        {
            string? raw = Environment.GetEnvironmentVariable(EnvironmentVariable);
            return string.IsNullOrWhiteSpace(raw) ? DefaultLocalValue : raw.Trim();
        }
    }
}
