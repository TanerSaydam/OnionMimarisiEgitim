using MediatR;
using Microsoft.AspNetCore.Identity;
using OnionMimarisi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Commands.UserFeature.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly UserManager<AppUser> _userManager;

        public CreateUserCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            AppUser user = new AppUser { Id = Guid.NewGuid().ToString(), UserName = request.UserName, Email = request.Email };
            await _userManager.CreateAsync(user, request.Password);
            return new CreateUserCommandResponse { User = user };
        }
    }
}
