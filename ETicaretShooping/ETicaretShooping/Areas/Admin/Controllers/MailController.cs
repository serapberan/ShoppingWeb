using ETicaretShooping.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ETicaretShooping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Route("Admin/[controller]/[action]")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MailConfirmationViewModel m)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("EShooping","srpberan@gmail.com"); //gönderen bilgisi
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", m.ReceiverMail); //alıcının adresi
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();    //içerik 
            bodyBuilder.TextBody = m.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = m.Subject;   //konu

         

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("srpberan@gmail.com", "ylogbbwrqfewibch");  //kim tarafından gönderiliyor
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
