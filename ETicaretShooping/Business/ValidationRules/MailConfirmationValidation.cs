using DTO.DTOs.MailDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class MailConfirmationValidation : AbstractValidator<MailConfirmationDto>
    {
        public MailConfirmationValidation()
        {
            RuleFor(x => x.SenderMail).NotEmpty().WithMessage("Lütfen adınızı giriniz.");
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Lütfen soyadınızı giriniz.");
            RuleFor(x => x.Body).NotEmpty().WithMessage("Lütfen kullanıcı adınızı giriniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfen Şifrenizi giriniz.");     
        }
    }
}
