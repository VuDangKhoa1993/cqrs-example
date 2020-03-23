using learn_cqrs.Domain.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learn_cqrs.Domain.Model;

namespace learn_cqrs.Domain.Queries
{
    public class ListUserQuery : IRequest<IEnumerable<User>>
    {
        
    }
}
