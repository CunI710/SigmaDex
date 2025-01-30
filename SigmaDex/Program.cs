using Application.Services;
using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using DataAccess.Repositories;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using SigmaDex.Profiles;
using System.Net;
using DataAccess.Options;
using BLL.Options;
using Application.Authorization;
using Core.Enums.OptionEnums;
using Microsoft.AspNetCore.Authorization;
using SigmaDex.Extentions;
using Microsoft.OpenApi.Models;
using Application.Providers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<SigmaDbContext>(options=>options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ISigmaRepository, SigmaRepository>();
builder.Services.AddScoped<ISigmaTypeRepository, SigmaTypeRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISigmaService, SigmaService>();
builder.Services.AddScoped<ISigmaTypeService, SigmaTypeService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IPermissionService, PermissionService>();
builder.Services.AddScoped<ILoginService, LoginService>();

builder.Services.AddScoped<JwtProvider>();

builder.Services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();

builder.Services.AddAutoMapper(typeof(MappingProfile));


builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen(options => {
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Token"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(nameof(JwtOptions)));
builder.Services.Configure<DataAccess.Options.AuthorizationOptions>(builder.Configuration.GetSection(nameof(DataAccess.Options.AuthorizationOptions)));

builder.Services.AddApiAuthentication(builder.Configuration.GetSection(nameof(JwtOptions)).Get<JwtOptions>());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();


app.UseCors(builder => builder.AllowAnyOrigin());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
