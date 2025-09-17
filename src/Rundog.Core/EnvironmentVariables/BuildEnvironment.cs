namespace Rundog.Core.EnvironmentVariables;

/// <summary>
///     A static utility class for retrieving and querying the current build environment.
/// </summary>
public static class BuildEnvironment
{
    internal const string EnvironmentVariable = "BUILD_ENVIRONMENT";
    internal const string DefaultLocalValue = "Local";
    internal const string ProductionEnvName = "Production";

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

    /// <summary>
    ///     Indicates whether the current build environment is considered a production environment.
    /// </summary>
    public static bool IsProduction =>
        string.Equals(Value, ProductionEnvName, StringComparison.OrdinalIgnoreCase);
}
