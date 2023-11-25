using Blog.Application;
using Blog.Infrastructure.DataAcess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDatabase();
builder.Services.AddRepositories();
builder.Services.AddValidators();

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

app.MapControllers();

app.Run();
