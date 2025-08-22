using Microsoft.Extensions.DependencyInjection;
using WebApiPaulo.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddEntityFrameworkSqlite()
//    .AddDbContext<SistemaVendasDBContext>();

// builder.Services.AddSwaggerGen();


//Swashbuckle.AspNetCore.SwaggerGen.SwaggerGeneratorOptions options = new();

//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new() { Title = "My API", Version = "v1" });
//});




var app = builder.Build();
//app.MapSwagger();
//app.UseSwagger();




// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
