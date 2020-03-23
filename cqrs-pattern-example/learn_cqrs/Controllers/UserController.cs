using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learn_cqrs.Domain.Model;
using learn_cqrs.Domain.Queries;
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
    }
}