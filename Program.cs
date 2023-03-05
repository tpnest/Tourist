using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Tourist.Database;
using Tourist.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(opt =>
{
    opt.ReturnHttpNotAcceptable = true;

}).AddXmlDataContractSerializerFormatters()
    .ConfigureApiBehaviorOptions(setupAction =>
    {
        setupAction.InvalidModelStateResponseFactory = context =>
        {
            var problemDetail = new ValidationProblemDetails(context.ModelState)
            {
                Type = "错误",
                Title = "数据验证失败",
                Status = StatusCodes.Status422UnprocessableEntity,
                Detail = "请看详细说明",
                Instance = context.HttpContext.Request.Path
            };
            problemDetail.Extensions.Add("traceId", context.HttpContext.TraceIdentifier);
            return new UnprocessableEntityObjectResult(problemDetail)
            {
                ContentTypes = { "application/problem+json" }
            };
        };
    });
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
