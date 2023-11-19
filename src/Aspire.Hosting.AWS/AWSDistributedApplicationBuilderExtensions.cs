using Aspire.Hosting.AWS;
using Aspire.Hosting.Publishing;
using Microsoft.Extensions.DependencyInjection;

namespace Aspire.Hosting;

/// <summary>
/// Extensions to <see cref="IDistributedApplicationBuilder"/> related to AWS.
/// </summary>
public static class AWSDistributedApplicationBuilderExtensions
{
    /// <summary>
    /// Adds AWS support to Aspire.
    /// </summary>
    /// <param name="builder">The distributed application builder instance.</param>
    /// <param name="options">Options for configuring Dapr, if any.</param>
    /// <returns>The distributed application builder instance.</returns>
    public static IDistributedApplicationBuilder AddAWS(this IDistributedApplicationBuilder builder, AWSOptions? options = null)
    {
        // Publishing
        builder.Services.AddKeyedSingleton<IDistributedApplicationPublisher, AWSCDKPublisher>("cdk");
        return builder;
    }
}
