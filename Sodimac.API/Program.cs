using Microsoft.EntityFrameworkCore;
using Sodimac.Business.Implementations;
using Sodimac.Business.Interfaces;
using Sodmac.Data;
using Sodmac.Data.Entities.Implementations;
using Sodmac.Data.Entities.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IComprometidasRepository, ComprometidasRepository>();
builder.Services.AddTransient<IComprometidasService, ComprometidasService>();

builder.Services.AddTransient<IDespachadasRepository, DespachadasRepository>();
builder.Services.AddTransient<IDespachadasService, DespachadasService>();

builder.Services.AddTransient<IUbicacionesRepository, UbicacionesRepository>();
builder.Services.AddTransient<IUbicacionesService, UbicacionesService>();

builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlite("name=DefaultConnection"));

builder.Services.AddAutoMapper(typeof(Program));
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

