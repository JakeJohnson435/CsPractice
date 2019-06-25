using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Middlewares
{
    public class CustomMiddleware
    {

        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Debug.WriteLine($" ---> Request asked for {httpContext.Request.Path}");

            // Call the next middleware delegate in the pipeline
            await _next.Invoke(httpContext);
        }

    }
}
