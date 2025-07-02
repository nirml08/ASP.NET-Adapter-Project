
using adapter.Services;
using adapter.Repo;
using adapter.Dbpool;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<Apical>();
builder.Services.AddScoped<dbcontext>();
builder.Services.AddScoped<socketrepo>();
builder.Services.AddScoped<socketservice>();
builder.Services.AddScoped<StudentInsertService>();



builder.Services.AddHttpClient<Apical>();

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
