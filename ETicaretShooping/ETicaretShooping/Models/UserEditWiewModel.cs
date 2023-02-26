using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Models
{
    public class UserEditWiewModel
    {

        [Required(ErrorMessage = "Kullanıcı Ad alanı boş bırakılamaz.")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; } = null!;

        [EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz.")]
        [Display(Name = "Telefon :")]
        public string Phone { get; set; } = null!;

        [DataType(DataType.Date)]
        [Display(Name = "Doğum tarihi :")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Şehir :")]
        public string City { get; set; }

        [Display(Name = "Profil resmi :")]
        public IFormFile ImageURL { get; set; }
        //public Gender? Gender { get; internal set; }

         //[Display(Name = "Cinsiyet :")]
         public Gender Gender { get; set; }
    }
}
