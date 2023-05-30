using TaskService.Infrastructure.Extensions;
using TaskService.Application.Extensions;
using TaskService.API;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddAuthentication();
builder.Services.AddAutoMapper(cfg => cfg.AddProfile(typeof(MappingProfiles)));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MigrateDatabase();
app.UseAuthorization();

app.MapControllers();

app.Run();

