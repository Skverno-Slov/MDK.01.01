using DbLibrary.DataBase;
using DbLibrary.Repositories;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// DB work
string connectionString = "Data Source=mssql;Initial Catalog=ispp3114;Persist Security Info=True;User ID=ispp3114;Password=3114;Trust Server Certificate=True";
builder.Services.AddSingleton<IDbConnectionFactory>(new MsSqlFactory(connectionString));
//builder.Services.AddSingleton<IDbConnectionFactory>(new SqliteFactory(connectionString));
builder.Services.AddScoped<GamesRepository>();

// Add services to the container.

builder.Services.AddControllers();
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
