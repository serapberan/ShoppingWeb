using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Models
{
    public class CustomerIdentityValidator   : IdentityErrorDescriber // hata mesajlarını türkçeleştirme 
    {

        public override IdentityError PasswordTooShort(int length) 
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Parola Minimum {length} karekter olmalıdır"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = $"Parolada  En az 1 büyük harf  olmalıdır"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = $"Parolada  En az 1 küçük harf  olmalıdır"
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = $"Parolada  En az 1 sembol harf  olmalıdır"
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = $"Parolada  En az (0 - 9) arasında bir rakam içermelidir."
            };
        }
    }
}
