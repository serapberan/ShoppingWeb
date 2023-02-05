using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Models
{
    public class UserEditProfileViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string ImageURL { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public IFormFile Image { get; set; }
    }
}
