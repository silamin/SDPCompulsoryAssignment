using Application.DTOs;
using AutoMapper;
using Domain;
using FluentValidation;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Dependancy resolver
Application.DependancyResolver.DependancyResolverService.RegisterApplicationLayer(builder.Services);
Infrastructure.DependencyResolver.DependencyResolverService.RegisterInfrastructureLayer(builder.Services);


//Automapper for DTOs
var mapper = new MapperConfiguration(config =>
    config.CreateMap<PostBoxDTO, Box>())
    .CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddDbContext<ProductDBContext>(options => options.UseSqlite(
    "Data source= db.db"));
builder.Services.AddScoped<ProductRepository>();

builder.Services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(options =>
    {
	    options.AllowAnyOrigin();
	    options.AllowAnyHeader();
	    options.AllowAnyMethod();
    });
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();