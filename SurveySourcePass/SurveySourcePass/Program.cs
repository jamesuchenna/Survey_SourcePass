using Microsoft.EntityFrameworkCore;
using SurveySourcePass.DAL;
using SurveySourcePass.Extensions;
using SurveySourcePass.Repository;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
        options
        .UseSqlServer(Configuration.GetConnectionString("Survey"))
        );
builder.Services.AddScoped<IAppDbContext, AppDbContext>();
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<ISurveyRepository, SurveyRepository>();


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
