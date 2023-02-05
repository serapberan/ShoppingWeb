using DTO.DTOs.NotificationDTOs;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class NotificationValidation : AbstractValidator<NotificationAddDto>
    {
        public NotificationValidation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlığı boş geçmeyiniz.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Duyuru boş geçmeyiniz.");
        }
    }
}
