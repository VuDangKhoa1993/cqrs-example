using learn_cqrs.Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Commands.Users
{
    public class CreateUserCommand : IRequest<User>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public CreateUserCommand(string name, int age )
        {
            Name = name;
            Age = age;
        }
    }
}
