
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


//builder.Services.AddDbContext<r1db>(options =>options.UseMySql(
//builder.Configuration.GetConnectionString("DefaultConnection"),
//  new MySqlServerVersion(new Version(8, 0, 36)) // Use your actual MySQL version
//));

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
