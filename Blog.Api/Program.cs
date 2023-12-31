using Blog.Api;
using Blog.Application;
using Blog.Application.Services;
using Blog.Infrastructure.DataAcess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDatabase(builder.Configuration.GetConnectionString("Default"));
builder.Services.AddRepositories();
builder.Services.AddApplicationServices();
builder.Services.AddValidators();

builder.Services.AddCookieAuthentication();
builder.Services.AddControllers();
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

app.UseExceptionMiddleware();

app.MapControllers();

app.Run();
