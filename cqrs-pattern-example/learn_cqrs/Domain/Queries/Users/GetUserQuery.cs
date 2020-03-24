using learn_cqrs.Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Queries.Users
{
    public class GetUserQuery : IRequest<User>
    {
        public int UserId { get; set; }
        public GetUserQuery(int userId)
        {
            UserId = userId;
        }
    }
}
