using Application.User.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class UserController : Controller
    {
        private readonly ISender _Sender;

        public UserController(ISender sender)
        {
            _Sender = sender;
        }

        public async Task<Guid> Create(string name, string email, string family)
        {
            var command = new CreateUserCommand {
                Name = name,
                Email = email,
                Family = family
            };
            return await _Sender.Send(command);    
        }
    }
}
