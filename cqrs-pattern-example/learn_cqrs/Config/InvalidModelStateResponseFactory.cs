using learn_cqrs.Domain.Resource;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs
{
    public static class InvalidModelStateResponseFactory
    {
        public static IActionResult ProduceErrorResponse(ActionContext context)
        {
            var errors = context.ModelState.SelectMany(x => x.Value.Errors).Select(m => m.ErrorMessage).ToList();
            var response = new ErrorResources(errors);
            return new BadRequestObjectResult(response);
        }
    }
}
