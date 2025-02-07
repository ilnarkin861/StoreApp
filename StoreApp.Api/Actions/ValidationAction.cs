using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using StoreApp.Application.DTO;

namespace StoreApp.Api.Actions;

public class ValidationAction : ActionFilterAttribute
{
	public override void OnActionExecuted(ActionExecutedContext context)
	{
		var response = new DefaultResponse();
		
		if (context.ModelState.IsValid) return;
            
		foreach (var value in context.ModelState.Values)
		{
			response.ErrorMessages.AddRange(value.Errors.Select(error => error.ErrorMessage));
		}
		
		response.StatusCode = (int) HttpStatusCode.BadRequest;
		
		context.Result = new BadRequestObjectResult(response);
	}
}