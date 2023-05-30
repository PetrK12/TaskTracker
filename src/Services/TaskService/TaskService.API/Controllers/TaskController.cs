using System;
using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskService.Application.Commands.CreateTask;
using TaskService.Application.Commands.DeleteTask;
using TaskService.Application.Queries;
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

		[HttpPost(Name = "CreateTask")]
		[ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
		public async Task<IActionResult> CreateTask([FromBody] CreateTaskCommand cmd)
		{
			var result = await _mediator.Send(cmd);
			return Ok(result);
		}

		[HttpDelete("{id}",Name ="DeleteTask")]
		[ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
		public async Task<IActionResult> DeleteTask(int id)
		{
			var result = await _mediator.Send(new DeleteTaskCommand(id));
			return Ok(result);
		}

        [HttpGet(Name = "ListTasks")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ListTask()
        {
            var result = await _mediator.Send(new ListTaskQuery());
            return Ok(result);
        }
    }
}

