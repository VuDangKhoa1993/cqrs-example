using learn_cqrs.Domain.Model;
using learn_cqrs.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Queries.Users
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, User>
    {
        private readonly IUserRepository _userRepository;
        public GetUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            if(request.UserId < 0)
            {
                throw new ArgumentException(nameof(request.UserId));
            }
            return await _userRepository.FindByIdAsync(request.UserId);
        }
    }
}
