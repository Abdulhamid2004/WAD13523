using Microsoft.EntityFrameworkCore;
using WAD13523.DAL.Data;
using WAD13523.DAL.Models;
using WAD13523.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

var corsSettings = "corsSettings";

builder.Services.AddCors(options =>
{
    options.AddPolicy(corsSettings,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
        });
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FilmReviewDbContext13523>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("SqlServerConnectionString"))
    );

builder.Services.AddScoped<IRepository<Film13523>, FilmRepository13523>();
builder.Services.AddScoped<IRepository<Review13523>, ReviewRepository13523>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(corsSettings);

app.MapControllers();

app.Run();
