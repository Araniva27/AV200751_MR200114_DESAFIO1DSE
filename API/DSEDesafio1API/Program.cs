using Desafio.BL.Automapper;
using Desafio.BL.Interfaces;
using Desafio.BL.Services;
using Desafio.Common;
using Desafio.DAL.Interfaces;
using Desafio.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddAutoMapper(typeof(AutomapperProfile));
builder.Services.AddScoped<IDatabaseRepository, DatabaseRepository>();
builder.Services.AddTransient<IProductoService, ProductoService>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();

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
