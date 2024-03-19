using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Adicionando conex�o(ad��o de contexto) para o Mysql
var connectionMysql = builder.Configuration.GetConnectionString("ConnectionMysql");
    builder.Services.AddDbContext<ConnectionContext>(options => options.UseMySql(connectionMysql, ServerVersion.Parse("10.4.24 - MariaDB")));


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
