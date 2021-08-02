using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.Middleware
{
    public class shortCircuitMiddleware
    {
        public RequestDelegate _next;

        public shortCircuitMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async  Task Invoke(HttpContext httpContext)
        {
            if(httpContext.Request.Headers["User-Agent"].Any(h => h.ToLower().Contains("edge")))
            {
                httpContext.Response.StatusCode = 403;
            }
            else
            {
                await _next.Invoke(httpContext);
            }
        }

    }
}
