using FeedbackProj.Interface;
using FeedbackProj.Models;
using FeedbackProj.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RatingContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("con")));
builder.Services.AddScoped<IRating, RatingRepo>();
builder.Services.AddScoped<IFeedback, FeedbackRepo>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Corspolicy", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
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
app.UseCors("Corspolicy");
app.MapControllers();

app.Run();
