using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Models
{
    public class UserSignInViewModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string  EMail { get; set; }
    }
}
