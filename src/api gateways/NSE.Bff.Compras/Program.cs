using NSE.Bff.Compras.Configuration;
using NSE.WebApi.Core.Identidade;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddApiConfiguration(configuration);
builder.Services.AddJwtConfiguration(configuration);
builder.Services.RegisterServices();
builder.Services.AddSwaggerConfiguration();

var app = builder.Build();
app.UseApiConfiguration(app.Environment);

app.UseSwaggerConfiguration();
app.Run();
