var builder = DistributedApplication.CreateBuilder(args);

builder.AddAWS();
builder.AddAWSProvisioning();

builder.AddProject<Projects.ServerlessWebApi>("webapi");

using var app = builder.Build();

await app.RunAsync();