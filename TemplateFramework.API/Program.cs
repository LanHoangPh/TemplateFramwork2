using Microsoft.OpenApi.Models;
using Serilog.Events;
using Serilog;
using TemplateFramework.Application.DependencyInjection;
using TemplateFramework.Infastructure.DependencyInjection;
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;
using TemplateFramework.API.Extension;
using TemplateFramework.API.Midleware;

namespace TemplateFramework.API
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .Enrich.WithProperty("ApplicationName", "TemplateFramwork.WebAPI")
                .WriteTo.Console()
                .WriteTo.File("logs/log-.txt",
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 30)
                .CreateLogger();
            try
            {
                Log.Information("Starting TemplateFramwork WebAPI application");
                var builder = WebApplication.CreateBuilder(args);

                builder.Logging.ClearProviders();
                builder.Host.UseSerilog();

                builder.Services.AddControllers();
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddApplicationServices(builder.Configuration);
                builder.Services.AddInafstructureServices(builder.Configuration);
                builder.Services.AddSwaggerGen();
                // cau hinh rate limiter
                builder.Services.AddRateLimiter(options =>
                {
                    options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;

                    options.AddFixedWindowLimiter(policyName: "fixed", opt =>
                    {
                        opt.PermitLimit = 10;
                        opt.Window = TimeSpan.FromSeconds(10);
                        opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                        opt.QueueLimit = 2; 
                    });
                    options.AddSlidingWindowLimiter(policyName: "sliding", opt =>
                    {
                        opt.PermitLimit = 100;
                        opt.Window = TimeSpan.FromMinutes(1);
                        opt.SegmentsPerWindow = 5; 
                    });

                    options.AddTokenBucketLimiter(policyName: "token", opt =>
                    {
                        opt.TokenLimit = 20;
                        opt.QueueLimit = 0;
                        opt.TokensPerPeriod = 5;
                        opt.ReplenishmentPeriod = TimeSpan.FromMinutes(1);
                    });
                    options.AddConcurrencyLimiter(policyName: "concurrency", opt =>
                    {
                        opt.PermitLimit = 4; 
                    });
                });

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
                    app.UseDeveloperExceptionPage();
                }

                app.UseSerilogRequestLogging();
                app.UseRateLimiter();
                app.UseHttpsRedirection();
                app.UseRequestLogging();
                app.UseExceptionHandler("/error");
                app.UseMiddleware<ExceptionHandlingMiddleware>();

                app.UseCors("AllowAll");
                app.UseAuthentication();
                app.UseAuthorization();

                //using (var scope = app.Services.CreateScope())
                //{
                //    var dbContext = scope.ServiceProvider.GetRequiredService<TemplateDbContext>();
                //    dbContext.Database.Migrate();
                //}

                app.MapControllers();

                Log.Information("TemplateFramwork WebAPI application started successfully");

                app.Run();

        }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application terminated not strarted!");
            }
            finally
            {
                Log.CloseAndFlush();
            }

        }
    }
}
