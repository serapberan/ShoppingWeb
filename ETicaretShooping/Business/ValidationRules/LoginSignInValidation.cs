using DTO.DTOs.RegisterDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class LoginSignInValidation : AbstractValidator<LoginSignInDto>
    {
        public LoginSignInValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen adınızı giriniz.");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Lütfen soyadınızı giriniz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Lütfen kullanıcı adınızı giriniz."); 
        }
    }
}
