using DocumentationWebSiteApi.Extentions;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

var app = builder.Build();

await app.ConfigurePipelineAsync();

app.Run();
