using DTO.DTOs.Profile;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ProfileUpdateValidation : AbstractValidator<ProfileUpdateDto>
    {
        public ProfileUpdateValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen adınızı giriniz.");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Lütfen soyadınızı giriniz.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Lütfen kullanıcı adınızı giriniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen Şifrenizi giriniz.");
            RuleFor(x => x.Password).MinimumLength(5).WithMessage("Lütfen Enaz 6 karekter giriniz.");
            RuleFor(x => x.RePassword).Equal(x => x.RePassword).WithMessage("Şifreler uyuşmadı. Tekrar deneyin..");
        }
    }
}
