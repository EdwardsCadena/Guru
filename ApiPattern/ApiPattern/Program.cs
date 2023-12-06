using ApiPattern.Core.Interfaces;
using ApiPattern.Infrastructure.Data;
using ApiPattern.Infrastructure.Logic;
using ApiPattern.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// PATRÓN: Inyección de Dependencias
    // Se añade el servicio CORS a la aplicación
builder.Services.AddCors();
    //Conexión a la base de datos
builder.Services.AddDbContext<PruebaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("pru"));
});
builder.Services.AddTransient<ILogEntryRepository, LogEntryRepository>();
builder.Services.AddTransient<ILogExercise, LogicExercise>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// PATRÓN: Middleware
// Se añade el middleware CORS 
app.UseCors(builder =>
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();