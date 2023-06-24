using NSE.Identidade.API.Configuration;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.AddIdentityConfiguration(configuration);
builder.Services.AddApiConfiguration();
builder.Services.AddSwaggerConfiguration();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMessageBusConfiguration(configuration);

var app = builder.Build();
app.UseSwaggerConfiguration();
app.UseApiConfiguration(app.Environment);

app.Run();
