using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebcCoreEntrtyFramment.CommentTool
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"this {nameof(CustomActionFilterAttribute)}OnActionExecuting :{Order}");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"this {nameof(CustomActionFilterAttribute)}OnActionExecuted :{Order}");
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine($"this {nameof(CustomActionFilterAttribute)} OnResultExecuting :{Order}");
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine($"this {nameof(CustomActionFilterAttribute)}OnResultExecuted :{Order}");
        }

    }

    public class CustomControllerFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"this {nameof(CustomControllerFilterAttribute)}OnActionExecuting:{Order}");
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"this {nameof(CustomControllerFilterAttribute)}OnActionExecuted:{Order}");
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine($"this {nameof(CustomControllerFilterAttribute)}OnResultExecuting:{Order}");
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine($"this {nameof(CustomControllerFilterAttribute)}OnResultExecuted:{Order}");
        }
    }


    public class CustomGlobalFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"this {nameof(CustomGlobalFilterAttribute)}OnActionExecuting:{Order}");
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"this {nameof(CustomGlobalFilterAttribute)}OnActionExecuted:{Order}");
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine($"this {nameof(CustomGlobalFilterAttribute)}OnResultExecuting:{Order}");
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine($"this {nameof(CustomGlobalFilterAttribute)}OnResultExecuted:{Order}");
        }
    }

}
