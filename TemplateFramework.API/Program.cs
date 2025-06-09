
using Microsoft.OpenApi.Models;
using Serilog.Events;
using Serilog;
using TemplateFramework.Application.DependencyInjection;
using TemplateFramework.Infastructure.DependencyInjection;
using TemplateFramework.Infastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace TemplateFramework.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Logging.ClearProviders();
            builder.Host.UseSerilog();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddApplicationServices(builder.Configuration);
            builder.Services.AddInafstructureServices(builder.Configuration);
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseSerilogRequestLogging();
            app.UseHttpsRedirection();

            app.UseCors("AllowAll");
            app.UseAuthentication();
            app.UseAuthorization();

            //using (var scope = app.Services.CreateScope())
            //{
            //    var dbContext = scope.ServiceProvider.GetRequiredService<TemplateDbContext>();
            //    dbContext.Database.Migrate();
            //}

            app.MapControllers();

            //Log.Information("TemplateFramwork WebAPI application started successfully");

            app.Run();
            //Log.Logger = new LoggerConfiguration()
            //    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            //    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
            //    .Enrich.FromLogContext()
            //    .Enrich.WithMachineName()
            //    .Enrich.WithProperty("ApplicationName", "CleanArchitecture.WebAPI")
            //    .WriteTo.Console()
            //    .WriteTo.File("logs/application-.log",
            //        rollingInterval: RollingInterval.Day,
            //        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] [{SourceContext}] {Message:lj} {Properties:j}{NewLine}{Exception}",
            //        retainedFileCountLimit: 30)
            //    .CreateLogger();
            //try
            //{
            //    //Log.Information("Starting TemplateFramwork WebAPI application");
                

            //}
            //catch(Exception ex)
            //{
            //    Log.Fatal(ex, "Application terminated not strarted!");
            //}
            //finally
            //{
            //    Log.CloseAndFlush();
            //}
            
        }
    }
}
