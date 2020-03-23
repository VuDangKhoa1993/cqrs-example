using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learn_cqrs.Domain.Model;
using System.Threading;
using learn_cqrs.Domain.Repository;

namespace learn_cqrs.Domain.Queries
{
    public class ListUserQueryHandler : IRequestHandler<ListUserQuery, IEnumerable<User>>
    {
        private readonly IUserRepository _userRepository;
        public ListUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> Handle(ListUserQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.ListAsync();
        }
    }

}
