using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Commands
{
    public class CreateUserValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(10);
            RuleFor(x => x.Email).EmailAddress(EmailValidationMode.AspNetCoreCompatible);
            RuleFor(x=>x.Family).NotEmpty().NotNull().MinimumLength(10);
        }
    }
}
