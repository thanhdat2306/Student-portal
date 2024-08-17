﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortalAPI.Infrastructure.Attributes
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(e => e.Key, e => e.Value.Errors.Select(e => new
                    {
                        e.ErrorMessage
                    })).ToArray();

                context.Result = new BadRequestObjectResult(errors);
                return;
            }
            await next();
        }
    }
}
