using NSE.WebApp.MVC.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvcConfiguration(builder.Configuration);
builder.Services.AddIdentityConfiguration();
builder.Services.RegisterServices(builder.Configuration);

var app = builder.Build();
app.UseMvcConfiguration(app.Environment);
app.Run();
