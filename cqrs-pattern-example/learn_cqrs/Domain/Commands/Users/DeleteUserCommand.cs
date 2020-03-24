using learn_cqrs.Domain.Communication;
using learn_cqrs.Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Commands.Users
{
    public class DeleteUserCommand : IRequest<Response<User>>
    {
        public int UserId { get; private set; }
        public DeleteUserCommand(int userId)
        {
            UserId = userId;
        }
    }
}
