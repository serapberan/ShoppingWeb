using DTO.DTOs.RegisterDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class LoginValidation : AbstractValidator<LoginDto>
    {
        public LoginValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen adınızı giriniz.");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Lütfen soyadınızı giriniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen Şifrenizi giriniz.");
        }

    }
}
