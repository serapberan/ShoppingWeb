using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Models
{
    public class ForgetPasswordViewModel
    {
        [EmailAddress(ErrorMessage = "Geçersiz Email Formatı")]
        [Required(ErrorMessage = "Email Alanı Boş Geçilemez")]
        [Display(Name = "Email:")]
        public string Email { get; set; }

    }
}
