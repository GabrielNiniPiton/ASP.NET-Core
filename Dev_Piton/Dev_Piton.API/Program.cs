using Dev_Piton.API.Models;
using Dev_Piton.Application.Services.Implementations;
using Dev_Piton.Application.Services.Interfaces;
using Dev_Piton.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<OpeningTimeOption>(builder.Configuration.GetSection("OpeningTime"));

builder.Services.AddSingleton<DevFreelaDbContext>();

builder.Services.AddScoped<IProjectService, ProjectService>();

builder.Services.AddSingleton<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" });

builder.Services.AddControllers();
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