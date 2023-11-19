namespace Microsoft.Extensions.Hosting;

public static class ServerlessApplicationHostExtensions
{
    public static IHostApplicationBuilder AddServiceDefaults(this IHostApplicationBuilder builder)
    {
        return builder;
    }
}