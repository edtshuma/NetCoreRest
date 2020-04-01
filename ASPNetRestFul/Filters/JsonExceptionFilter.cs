using ASPNetRestFul.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetRestFul.Filters
{
    public class JsonExceptionFilter : IExceptionFilter
    {
        private readonly IHostingEnvironment _env;

        public JsonExceptionFilter(IHostingEnvironment env)
        {
            _env = env;
        }
        public void OnException(ExceptionContext context)
        {
            var error = new ApiError();
            if (_env.IsDevelopment())
            {
                error.Message = context.Exception.Message;
                error.Detail = context.Exception.StackTrace;

            }

            else
            {
                error.Message = "An server error occurred";
                error.Detail= context.Exception.Message;
            }
            error.Message = context.Exception.Message;
            error.Detail = context.Exception.StackTrace;

            context.Result = new ObjectResult(error);
            {

                var StatusCode = 500;
            };
        }
    }
}
