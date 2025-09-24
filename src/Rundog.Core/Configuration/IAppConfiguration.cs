namespace Rundog.Core.Configuration;

/// <summary>
///     Interface for accessing application configuration values.
/// </summary>
public interface IAppConfiguration
{
    /// <summary>
    ///     Returns the current build environment from config (e.g., "Local", "Staging", "Production").
    /// </summary>
    string DeployEnvironment { get; }

    /// <summary>
    ///     Returns the current application version from config
    /// </summary>
    string AppVersion { get; }

    /// <summary>
    ///     Indicates whether the current build environment is considered a production environment.
    /// </summary>
    bool IsProduction { get; }
}
