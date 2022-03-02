using Microsoft.EntityFrameworkCore;
using StudentApp.Core.Repository;
using StudentApp.Core.Students.Services;
using StudentApp.Data;
using StudentApp.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<StudentDbContext>(option =>
{
    option.UseInMemoryDatabase(databaseName: "Test");
});

builder.Services.AddTransient<IStudentRepository,StudentRepository>();
builder.Services.AddTransient<IServiceStudents, ServiceStudents>();

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
