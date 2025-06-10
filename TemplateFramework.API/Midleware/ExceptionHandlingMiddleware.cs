using Microsoft.EntityFrameworkCore;
using MySqlConnector;

namespace TemplateFramework.API.Midleware
{
    public class ExceptionHandlingMiddleware(RequestDelegate request)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await request(context);
            }
            catch (DbUpdateException ex)
            {
                var loger = context.RequestServices.GetRequiredService<ILogger<ExceptionHandlingMiddleware>>();
                context.Response.ContentType = "application/json";
                if (ex.InnerException is MySqlException innerException)
                {
                    loger.LogError(innerException, "MySql Exception");
                    switch (innerException.Number)
                    {
                        case 1062:
                            context.Response.StatusCode = StatusCodes.Status409Conflict;
                            await context.Response.WriteAsync("Unique constraint violation");
                            break;
                        case 1451:
                            context.Response.StatusCode = StatusCodes.Status400BadRequest;
                            await context.Response.WriteAsync("can not insert Foreign key constraint fails");
                            break;
                        case 1452:
                            context.Response.StatusCode = StatusCodes.Status400BadRequest;
                            await context.Response.WriteAsync("can not insert Foreign key constraint fails");
                            break;
                        default:
                            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                            await context.Response.WriteAsync("An error occurred while saving the enity changes");
                            break;
                    }
                }
                else
                {
                    loger.LogError(ex, "Realated EFcore Exception");
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    await context.Response.WriteAsync("An error occurred while saving the enity changes");
                }
            }
            catch (Exception ex)
            {
                var loger = context.RequestServices.GetRequiredService<ILogger<ExceptionHandlingMiddleware>>();
                loger.LogError(ex, "Unknow Exception");
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync($"Error: {ex.Message}");
            }
        }
    }
}
