using TaskService.Infrastructure.Extensions;
using TaskService.Application.Extensions;
using TaskService.API;
using System.Reflection;
using Microsoft.OpenApi.Models;
using TaskService.API.Services;

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
builder.Services.ConfigureJwt(builder.Configuration);
builder.Services.AddScoped<IAuthManager, AuthManager>();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer schema.
                        Enter 'Bearer' [space] and then your token in the text input bellow
                        Example: 'Bearer 12234asfk'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement{ 
        {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            },
            Scheme = "Oauth2",
            Name = "Bearer",
            In = ParameterLocation.Header
        },
        new List<string>()
    }
    });
    
    c.SwaggerDoc("v1", new OpenApiInfo{Title = "TaskService.API", Version = "v1"});
});


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

