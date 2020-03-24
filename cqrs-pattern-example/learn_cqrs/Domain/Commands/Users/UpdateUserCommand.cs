using learn_cqrs.Domain.Communication;
using learn_cqrs.Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Commands.Users
{
    public class UpdateUserCommand : IRequest<Response<User>>
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public UpdateUserCommand(int userId, string name, byte age)
        {
            UserId = userId;
            Name = name;
            Age = age;
        }
    }
}
