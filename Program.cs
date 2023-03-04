using Microsoft.EntityFrameworkCore;
using Tourist.Database;
using Tourist.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(opt =>
{
    opt.ReturnHttpNotAcceptable = true;

}).AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ITouristRouteRepository, TouristRouteRepository>();

// AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

string? connStr = builder.Configuration.GetSection("ConnectionStrings")["SqlServer"];
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(connStr);
});

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
