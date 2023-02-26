using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using ETicaretShooping.Models;
using System.Threading.Tasks;
using System.Net;

namespace ETicaretShooping.MailHelper
{
    public static class ForgetPassword
    {
   
        public static void SendResetPasswordEmail(string resetPasswordEmailLink,string email)
        {
            var smptClient = new SmtpClient();

            smptClient.Host = "smtp.gmail.com";
            smptClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smptClient.UseDefaultCredentials = false;
            smptClient.Port = 587;
            smptClient.Credentials = new NetworkCredential("srpberan@gmail.com", "rgpcgnjdnfpnwdic");
            smptClient.EnableSsl = true;

            var mailMessage = new MailMessage();

            mailMessage.From = new MailAddress("srpberan@gmail.com");
            mailMessage.To.Add(email);

            mailMessage.Subject = "EShopping | Şifre Yenileme Linki";
            mailMessage.Body = @$"
                  <h4>Şifrenizi yenilemek için aşağıdaki linkte tıklayınız.</h4>
                  <p><a href='{resetPasswordEmailLink}'>şifre yenileme linki</a></p>";

            mailMessage.IsBodyHtml = true;
            smptClient.Send(mailMessage);

        }
    }
}
