using Microsoft.EntityFrameworkCore;
using pc1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var _config = builder.Configuration;
var cnx = _config.GetConnectionString("DevConnnection");
builder.Services.AddDbContext<EventManagementDbContext>(options => options.UseSqlServer(cnx));


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

app.UseAuthorization();

app.MapControllers();

app.Run();
