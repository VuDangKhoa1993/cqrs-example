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
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Response<User>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UpdateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<User>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var existingUser = await _userRepository.FindByIdAsync(request.UserId);
            if(existingUser == null)
            {
                return new Response<User>("Not Found User");
            }
            existingUser.Age = request.Age;
            existingUser.Name = request.Name;
            _userRepository.Update(existingUser);
            await _unitOfWork.CompleteAsync();
            return new Response<User>(existingUser);
        }
    }
}
