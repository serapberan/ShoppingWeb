using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Models
{
    public class RoleCreateViewModel
    {
        [Required(ErrorMessage = "Role isim alanı boş bırakılamaz.")]
        [Display(Name = "Rol ismi :")]
        public string RoleName { get; set; }
    }
}
