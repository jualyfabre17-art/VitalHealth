using VitalHealth.Application;
using VitalHealth.Application.Service;
using VitalHealth.Infrastructure.Persistence.migrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Le decimos que cuando el servicio pida la interfaz, use el contexto real
builder.Services.AddScoped<IApplicationDbContext, AppointmentDbContext>();
builder.Services.AddScoped<AppointmentReservationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
