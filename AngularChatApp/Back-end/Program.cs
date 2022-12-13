using AngularChatApp.Configuration;
using AngularChatApp.Data;
using AngularChatApp.Repositories;
using AngularChatApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var settings = builder.Configuration.GetSection("ConnectionString").Get<ConnectionStrings>();

builder.Services.AddDbContext<UserContext>(options =>
{
    options.UseSqlServer(settings.SQL);
});

builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionString"));

builder.Services.AddControllers();

builder.Services.AddTransient<IUserContext, UserContext>();

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();

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
