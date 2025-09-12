using ECommerceFarming.Infrastructure.Context;
using ECommerceFarming.Infrastructure.UnitOfWork;
using ECommerceFarming.Infrastructure.UnitOfWork.Interface;
using ECommerceFarming.Service.LoginService;
using ECommerceFarming.Service.LoginService.Interface;
using Microsoft.EntityFrameworkCore;
using NLog.Web;

var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

try
{
    logger.Debug("App starting...");
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllers();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddDbContext<ECommerceDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

    // Add reponsitory
    builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

    // Add service
    builder.Services.AddTransient<ILoginService, LoginService>();

    builder.Services.AddControllers();

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
}
catch (Exception ex)
{
    logger.Error(ex, "Application error when starting");
    throw;
}
finally
{
    NLog.LogManager.Shutdown();
}