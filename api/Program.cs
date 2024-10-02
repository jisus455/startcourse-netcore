using api.services.Handlers;
using api.services.Repositories;
using api.services.Services;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => options.AddDefaultPolicy(builder =>
{
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
}));

// cadena de conexion a la base
SqliteHandlers.ConnectionString = builder.Configuration.GetConnectionString("defaultConnection");

// inyeccion de dependencias
// crea una instancia cada vez que se solicita
builder.Services.AddSingleton<IUserRepository, UserService>();
// agregamos la nueva tabla de configuracion de la pagina
builder.Services.AddSingleton<IConfigRepository, ConfigService>();
// agregamos la nueva tabla de articulos
builder.Services.AddSingleton<IArticulosRepository, ArticulosService>();
//..
builder.Services.AddSingleton<IDataBaseRepository, DataBaseService>();

// crea una unica instancia
// builder.Services.AddScoped <IUserRepository, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();
