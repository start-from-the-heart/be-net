using ECommerceFarming.Infrastructure.Reponsitory.Login;
using ECommerceFarming.Infrastructure.Reponsitory.Login.Interface;
using ECommerceFarming.Infrastructure.UnitOfWork;
using ECommerceFarming.Infrastructure.UnitOfWork.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Add reponsitory
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ILoginReponsitory, LoginReponsitory>();

builder.Services.AddControllers();

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