using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace GlobalWeb.Infra.Middleware
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate next;

        public ErrorMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (WebException ex)
            {
                await HandleExceptionAsync(context, ex, 500, "Internal Server Error API");
            }
            catch (ApplicationException ex)
            {
                await HandleExceptionAsync(context, ex, 401, "Internal Server Error API");
            }
            catch (UnauthorizedAccessException ex)
            {
                await HandleExceptionAsync(context, ex, 401, "Internal Server Error API");
            }
            catch (CustomException ex)
            {
                await HandleExceptionAsync(context, ex, ex.HttpStatusCode, ex.Title);
            }
            //catch (SqlException ex)
            //{
            //    await HandleExceptionAsync(context, ex, 500, "Internal Server Error Sql Server");
            //}
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, 500, "Internal Server Error API");
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception, int statusCode, string title)
        {
            HttpStatusCode code;

            if (statusCode == 422)
                code = HttpStatusCode.UnprocessableEntity;
            else if (statusCode == 400)
                code = HttpStatusCode.BadRequest;
            else if (statusCode == 401)
                code = HttpStatusCode.Unauthorized;
            else
                code = HttpStatusCode.InternalServerError;

            ErrorObjectModel errorObjects = new ErrorObjectModel()
            {
                status = statusCode.ToString(),
                source = context.Request.Path.Value,
                title = title,
                detail = exception.Message,
            };

            // Cria o response
            var result = JsonConvert.SerializeObject(new { errors = errorObjects });

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            return context.Response.WriteAsync(result);
        }

        public class ErrorObjectModel
        {
            public string status { get; set; }
            public string source { get; set; }
            public string title { get; set; }
            public string detail { get; set; }
        }
    }
}
