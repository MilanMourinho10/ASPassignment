using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SiliconApi.Attributes;

[AttributeUsage(AttributeTargets.All)]
public class UseApiKeyAttribute : Attribute, IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {

        var secret = "32aac325-b742-49cc-96b2-08bf4b48cf70";

        if (context.HttpContext.Request.Query.TryGetValue("key", out var key))
        {
            if (!string.IsNullOrEmpty(key))
            {
                if (secret == key)
                    await next();
            }
        }

        context.Result = new UnauthorizedResult();
        return;


    }
}
