using AutoMapper;
using Maraudr.Domain.Interfaces;
using Maraudr.Domain.Interfaces.Repositories;
using Maraudr.User.Infrastructure.Repositories; // Your repository namespace
using Maraudr.User.Application;
using Maraudr.User.Application.Mappers;
using Maraudr.User.Application.Services; // Your service namespace
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register AutoMapper and your profiles
builder.Services.AddAutoMapper(typeof(MappingProfile)); // Register MappingProfile for AutoMapper

// Register your services
builder.Services.AddScoped<IUserRepository, UserRepository>();  // Example repository registration
builder.Services.AddScoped<IUserService, UserService>(); // Example service registration

// Register OpenAPI / Swagger
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();  // This will map your controllers for API endpoints

app.Run();