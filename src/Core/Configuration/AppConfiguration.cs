using Microsoft.Extensions.Configuration;

namespace Rundog.Core.Configuration;

/// <summary>
///     Application configuration that reads from IConfiguration.
/// </summary>
public class AppConfiguration : IAppConfiguration
{
    internal const string DefaultVersion = "Not Set";
    private readonly IConfiguration _configuration;

    /// <summary>
    ///     Initializes a new instance of the <see cref="AppConfiguration" /> class.
    /// </summary>
    /// <param name="configuration">The configuration instance.</param>
    public AppConfiguration(IConfiguration configuration)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    /// <inheritdoc />
    public string DeployEnvironment
    {
        get
        {
            string? value = _configuration[Keys.DeployEnv];
            return string.IsNullOrWhiteSpace(value)
                ? DeployEnv.Local
                : value.Trim();
        }
    }

    /// <inheritdoc />
    public string AppVersion
    {
        get
        {
            string? value = _configuration[Keys.Version];
            return string.IsNullOrWhiteSpace(value)
                ? DefaultVersion
                : value.Trim();
        }
    }

    /// <inheritdoc />
    public bool IsProduction =>
        string.Equals(DeployEnvironment, DeployEnv.Production, StringComparison.OrdinalIgnoreCase);

    /// <summary>
    ///     Static constant class providing config key names
    /// </summary>
    internal static class Keys
    {
        /// <summary>
        ///     Config key for the current deployment environment
        /// </summary>
        internal const string DeployEnv = "DeployEnvironment";

        /// <summary>
        ///     Config key for the deployed app version
        /// </summary>
        internal const string Version = "AppVersion";
    }

    /// <summary>
    ///     Static constant class providing logical storage
    ///     for deployment environment names
    /// </summary>
    internal static class DeployEnv
    {
        /// <summary>
        ///     Used as a default to signal a local deployment
        /// </summary>
        internal const string Local = "Local";

        /// <summary>
        ///     Used as a comparison to signal whether the app is currently deployed to production
        /// </summary>
        internal const string Production = "Production";
    }
}
