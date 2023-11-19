using Aspire.Hosting.Lifecycle;
using Aspire.Hosting.Publishing;
using Microsoft.Extensions.Options;

namespace Aspire.Hosting.AWS.Provisioning.Provisioners;

internal sealed class AWSProvisioner(
    IOptions<AWSProvisionerOptions> options,
    IOptions<PublishingOptions> publishingOptions) : IDistributedApplicationLifecycleHook
{

    private readonly AWSProvisionerOptions _options = options.Value;

    public Task BeforeStartAsync(DistributedApplicationModel appModel,
        CancellationToken cancellationToken = default)
    {
        if (publishingOptions.Value.Publisher == "manifest")
        {
            return Task.CompletedTask;
        }

        return Task.CompletedTask;
    }
}