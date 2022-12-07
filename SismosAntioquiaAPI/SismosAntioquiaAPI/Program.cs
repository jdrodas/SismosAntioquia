using SismosAntioquiaAPI.Models;
using SismosAntioquiaAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null); 

builder.Services.Configure<SismosAntioquiaDatabaseSettings>(
    builder.Configuration.GetSection("SismosAntioquiaDatabase"));

builder.Services.AddSingleton<SismosService>();
builder.Services.AddSingleton<RegionesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
