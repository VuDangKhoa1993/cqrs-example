using learn_cqrs.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Repository
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
