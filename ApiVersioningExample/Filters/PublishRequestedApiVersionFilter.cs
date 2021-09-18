using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiVersioningExample.Filters
{
    public class PublishRequestedApiVersionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var httpContext = context.HttpContext;

            var v = httpContext.GetRequestedApiVersion();
            if (v != null)
                httpContext.Response.Headers.Add("Content-Version", v.ToString());
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}
