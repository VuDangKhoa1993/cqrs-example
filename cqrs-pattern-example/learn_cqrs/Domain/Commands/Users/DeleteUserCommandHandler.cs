using learn_cqrs.Domain.Communication;
using learn_cqrs.Domain.Model;
using learn_cqrs.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Commands.Users
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Response<User>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        public DeleteUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<User>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var existingUser = await _userRepository.FindByIdAsync(request.UserId);
            if(existingUser == null)
            {
                return new Response<User>("Not Found User");
            }
            _userRepository.Delete(existingUser);
            await _unitOfWork.CompleteAsync();
            return new Response<User>(existingUser);
        }
    }
}
