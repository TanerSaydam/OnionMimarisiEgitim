using OnionMimarisi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMimarisi.Application.Features.Commands.UserFeature.CreateUser
{
    public class CreateUserCommandResponse
    {
        public AppUser User { get; set; }
    }
}
