using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learn_cqrs.Domain.Commands.Users;
using learn_cqrs.Domain.Model;
using learn_cqrs.Domain.Queries;
using learn_cqrs.Domain.Queries.Users;
using learn_cqrs.Domain.Resource;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace learn_cqrs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _mediator.Send(new ListUserQuery());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var user = _mediator.Send(new GetUserQuery(id));
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]UserResource userResource)
        {
            var user = await _mediator.Send(new CreateUserCommand(userResource.Name, userResource.Age));
            return Created($"/api/users/{user.Id}", user);
        }

    }
}