using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Rundog.Core.Configuration;
using TestHelpers.Theory;

namespace Core.Unit.Tests.Configuration;

[TestSubject(typeof(AppConfiguration))]
public class AppConfigurationTest
{
    private static AppConfiguration CreateSut(
        string? version = null,
        string? env = null
    )
    {
        Dictionary<string, string?> configData = new();

        if (version != null)
        {
            configData[AppConfiguration.Keys.Version] = version;
        }

        if (env != null)
        {
            configData[AppConfiguration.Keys.DeployEnv] = env;
        }

        IConfiguration config = new ConfigurationBuilder()
            .AddInMemoryCollection(configData)
            .Build();

        return new AppConfiguration(config);
    }

    [Theory]
    [MemberData(nameof(TestData.NullOrWhitespace), MemberType = typeof(TestData))]
    public void DeployEnvironment_ReturnsLocal_WhenConfigurationValueIsUnset(string? empty)
    {
        // Arrange
        AppConfiguration sut = CreateSut(env: empty);
        const string expected = AppConfiguration.DeployEnv.Local;

        // Act
        string result = sut.DeployEnvironment;

        // Assert
        result.ShouldBe(expected);
    }

    [Theory]
    [MemberData(nameof(TestData.AlphanumericStringsWithSpecials), MemberType = typeof(TestData))]
    public void DeployEnvironment_ReturnsFromConfig_WhenConfigurationValueIsSet(string expected)
    {
        // Arrange
        AppConfiguration sut = CreateSut(env: expected);

        // Act
        string result = sut.DeployEnvironment;

        // Assert
        result.ShouldBe(expected);
    }


    [Theory]
    [MemberData(nameof(TestData.NullOrWhitespace), MemberType = typeof(TestData))]
    public void AppVersion_ReturnsDefault_WhenConfigurationValueIsUnset(string? empty)
    {
        // Arrange
        AppConfiguration sut = CreateSut(empty);
        const string expected = AppConfiguration.DefaultVersion;

        // Act
        string result = sut.AppVersion;

        // Assert
        result.ShouldBe(expected);
    }

    [Theory]
    [MemberData(nameof(TestData.AlphanumericStringsWithSpecials), MemberType = typeof(TestData))]
    public void AppVersion_ReturnsFromConfig_WhenConfigurationValueIsSet(string expected)
    {
        // Arrange
        AppConfiguration sut = CreateSut(expected);

        // Act
        string result = sut.AppVersion;

        // Assert
        result.ShouldBe(expected);
    }
}
