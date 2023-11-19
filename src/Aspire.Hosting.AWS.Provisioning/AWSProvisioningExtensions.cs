using Aspire.Hosting.AWS.Provisioning;
using Aspire.Hosting.AWS.Provisioning.Provisioners;
using Aspire.Hosting.Lifecycle;
using Microsoft.Extensions.DependencyInjection;

namespace Aspire.Hosting;

public static class AWSProvisioningExtensions
{
    /// <summary>
    /// Adds support for generating AWS resources dynamically during application startup.
    /// The application must configure the appropriate profile, region.
    /// </summary>
    public static IDistributedApplicationBuilder AddAWSProvisioning(this IDistributedApplicationBuilder builder)
    {
        builder.Services.AddLifecycleHook<AWSProvisioner>();

        // Attempt to read AWS configuration
        builder.Services.AddOptions<AWSProvisionerOptions>().BindConfiguration("AWS");

        return builder;
    }
}