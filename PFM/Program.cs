using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Writers;
using Npgsql;
using PFM.Application.UseCases.Queries.GetMessage;
using PFM.Domain.Interfaces;
using PFM.Infrastructure.Persistance.DbContexts;
using System.Net.Security;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<PFMDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PFM")));
builder.Services.AddScoped<IUnitOfWork>(sp => (IUnitOfWork)sp.GetRequiredService<PFMDbContext>());


builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(PFM.Application.AssemblyMarker).Assembly));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
