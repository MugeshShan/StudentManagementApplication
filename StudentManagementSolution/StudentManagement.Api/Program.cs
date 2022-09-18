using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using StudentManagement.Api.Data;
using StudentManagement.Api.Repositories;
using StudentManagement.Api.Repositories.Contract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextPool<StudentDbContext>(options => 
            options.UseSqlServer(builder.Configuration.GetConnectionString("StudentManagementConnections")));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy => policy.WithOrigins("http://localhost:7237", "https://localhost:7237")
                             .AllowAnyMethod()
                             .WithHeaders(HeaderNames.ContentType));
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
