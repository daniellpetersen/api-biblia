using api_biblia.Exceptions;
using Newtonsoft.Json;
using System.Net;
using System.Text.Json;

namespace api_biblia.Middlewares
{
    public class GlobalErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public GlobalErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionsAsync(context, ex);
            }
        }

        private static Task HandleExceptionsAsync(HttpContext context, Exception exception)
        {
            HttpStatusCode status;
            string stackTrace = String.Empty;
            string mensagem;
            var exceptionType = exception.GetType();

            if (exceptionType == typeof(NotFoundException)) 
            {
                mensagem = exception.Message;
                status = HttpStatusCode.NotFound;
                stackTrace = exception.StackTrace;
            }
            else
            {
                mensagem = exception.Message;
                status = HttpStatusCode.InternalServerError;
                stackTrace = exception.StackTrace;
            }

            //verificar essa questão
            string result = System.Text.Json.JsonSerializer.Serialize(new { status, mensagem, stackTrace });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)status;
            return context.Response.WriteAsync(result);
        }
    }
}
