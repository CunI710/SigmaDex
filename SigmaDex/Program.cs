using Application.Services;
using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using DataAccess.Repositories;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using SigmaDex.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<SigmaDbContext>(options=>options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ISigmaRepository, SigmaRepository>();
builder.Services.AddScoped<ISigmaTypeRepository, SigmaTypeRepository>();
builder.Services.AddScoped<ISigmaService, SigmaService>();
builder.Services.AddScoped<ISigmaTypeService, SigmaTypeService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
