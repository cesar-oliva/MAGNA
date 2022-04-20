using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace MAGNA_SERVER.WebApi.Config
{
    public class ExceptionMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        /// <summary>
        ///  El constructor recibe por inyeccion de dependencia el delegado del siguiente middleware
        ///  cada vez que se instancia un middleware sabe cual es el siguiente para poder delegarle
        ///  la ejecucion. tambien tenemos el parametro loggerFactoy que va a ser para poder contruir
        ///  un logger y poder logear las excepciones en el gestor de excepciones
        /// </summary>
        /// <param name="next"></param>
        /// <param name="loggerFactory"></param>
        public ExceptionMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<ExceptionMiddleware>();
        }
        /// <summary>
        /// Esta operacion se va a invocar cuando queremos delegar (es decir cuando el midelware anterior
        /// nos quiere delegar una ejecucion), es aqui donde se cachea de manera global.
        /// en el try ejecutamos el siguiente mildeware, encapsulamos todo el manejo de errores y todos los
        /// errores que se disparen dentro del siguiente mildeware hacia adelante se capturan dentro del try
        /// y en el catch con el logger creado con el logger factory vamos a logear el error con el mensaje que 
        /// queremos mas la excepcion y llamamos al metodo HandleGlobalExceptionAsync
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,$"Oooops! algo salio mal: {ex.Message}");
                await HandleGlobalExceptionAsync(httpContext, ex);
            }
        }
        /// <summary>
        /// creamos un metodo que maneja las excepciones de manera global y crea un response personalizado para informar al cliente
        /// crea una respuesta json, le ponemos el codigo del error (406) y creamos el response con el mensaje
        /// que algo salio mal y en el mismo mensaje muestro el stack trace. El error details se serializa y envia la respuesta.
        /// se ocupa de encapsular el error y enviar una respuesta.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        private static Task HandleGlobalExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.NotAcceptable;
            return context.Response.WriteAsync(JsonConvert.SerializeObject(new ErrorDetails()
            {
                StatusCode = StatusCodes.Status406NotAcceptable, //Custom error
                Message =  "Algo Salio Mal. Error!",
                StackTrace = exception.StackTrace
            }));

        }
    }
}
