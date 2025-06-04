using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateFramework.Application.DTOs.Auth;

namespace TemplateFramework.Application.Validations
{
    public class LoginUserDtoValidate : AbstractValidator<LoginDto>
    {
        public LoginUserDtoValidate()
        {
            RuleFor(x => x.EmailOrUsername)
                .NotEmpty().WithMessage("Username is required");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required");
        }
    }
}
