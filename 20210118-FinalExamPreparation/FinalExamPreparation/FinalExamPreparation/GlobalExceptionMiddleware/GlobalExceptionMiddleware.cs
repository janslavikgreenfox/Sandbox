using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FinalExamPreparation
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public GlobalExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception exception)
            {
                LogException(exception);
                ExceptionHandler(httpContext, exception);
            }
        }
        private void LogException(Exception exception)
        {
            File.AppendAllText("ExceptionLogger.txt",$"{DateTime.Now} : {exception.Message}");
        }

        public Task ExceptionHandler(HttpContext httpContext, Exception exception)
        {
            var response = httpContext.Response;
            response.ContentType = "application/json";
            var serializedBody = JsonSerializer.Serialize(new { message = exception.Message });
            return response.WriteAsync(serializedBody);
        }
    }
}
