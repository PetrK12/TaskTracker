using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskService.Application.Commands;
using static System.Net.WebRequestMethods;

namespace TaskService.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TaskController : ControllerBase
	{
		private readonly IMediator _mediator;

		public TaskController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<ActionResult<bool>> CreateTask([FromBody] CreateTaskCommand cmd)
		{
            await _mediator.Send(cmd);

			return Ok();
		}
	}
}

