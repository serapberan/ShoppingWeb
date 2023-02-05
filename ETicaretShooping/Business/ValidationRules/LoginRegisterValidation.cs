using DTO.DTOs.RegisterDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class LoginRegisterValidation : AbstractValidator<LoginRegisterDto>
    {
        public LoginRegisterValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen adınızı giriniz.");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Lütfen soyadınızı giriniz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Lütfen mail adresinizi giriniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen Şifrenizi giriniz.");
            RuleFor(x => x.Password).MinimumLength(5).WithMessage("Lütfen Enaz 6 karekter giriniz.");
            RuleFor(x => x.ConfigPassword).Equal(x=> x.ConfigPassword).WithMessage("Şifreler uyuşmadı. Tekrar deneyin..");
        }
    }
}
