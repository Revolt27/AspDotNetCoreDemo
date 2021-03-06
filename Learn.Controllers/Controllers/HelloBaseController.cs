﻿using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Learn.Controllers.Controllers
{
    public class HelloBaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers.ContainsKey("User-Agent") &&
                Regex.IsMatch(context.HttpContext.Request.Headers["User-Agent"].FirstOrDefault(), "MSIE 8.0"))
            {
                context.Result = Content("Internet Explorer 8.0 не поддерживается");
            }
            base.OnActionExecuting(context);
        }
    }
}
