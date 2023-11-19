using Amazon.CDK;
using Aspire.Hosting.Publishing;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public class AWSCDKPublisher(ILogger<AWSCDKPublisher> logger, IHostApplicationLifetime lifetime) : IDistributedApplicationPublisher

{

    private readonly ILogger<AWSCDKPublisher> _logger = logger;
    private readonly IHostApplicationLifetime _lifetime = lifetime;

    public virtual async Task PublishAsync(DistributedApplicationModel model, CancellationToken cancellationToken)
    {
        await PublishInternalAsync(model, cancellationToken).ConfigureAwait(false);
        _lifetime.StopApplication();
    }

    protected virtual Task PublishInternalAsync(DistributedApplicationModel model, CancellationToken cancellationToken)
    {
        var app = new App();
        var stack = new Stack(app, "Aspire");
        app.Synth();
        _logger.LogInformation("Published");
        return Task.CompletedTask;
    }
}