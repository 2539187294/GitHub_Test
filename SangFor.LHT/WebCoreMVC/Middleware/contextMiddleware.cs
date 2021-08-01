using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCoreMVC.Middleware
{
    public class contextMiddleware
    {
        private RequestDelegate _next;

        public contextMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if(httpContext.Request.Path.ToString().ToLower() == "/middleware")
            {
                await httpContext.Response.WriteAsync("这是middleware中间件", Encoding.Default);
            }
            else
            {
                await _next.Invoke(httpContext);
            }
        }

    }
}
