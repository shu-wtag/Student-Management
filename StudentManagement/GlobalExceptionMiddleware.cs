using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentManagement.API
{
    public class GlobalExceptionMiddleware : IMiddleware
    {
        private readonly ILogger<GlobalExceptionMiddleware> _logger;

        public GlobalExceptionMiddleware(ILogger<GlobalExceptionMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context); // Call the next middleware in the pipeline
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            // Log the exception
            _logger.LogError(ex, "An unhandled exception has occurred.");

            // Set the response status code
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            // Create the problem details
            ProblemDetails problem = new()
            {
                Status = context.Response.StatusCode,
                Type = "https://httpstatuses.com/500",
                Title = "Internal Server Error",
                Detail = "An internal server error has occurred."
            };

            // Serialize the problem details to JSON
            string json = JsonSerializer.Serialize(problem);
            context.Response.ContentType = "application/json";

            // Write the JSON response
            await context.Response.WriteAsync(json);
        }
    }
}
