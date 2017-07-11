using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using MimeKit;

namespace CompanyPage.Helpers
{
    public class MailHelper
    {
        public static void Send(string mailText, string subject, List<string> mails)
        {
            foreach (var mail in mails)
            {
                Send(mailText, subject, mail);
            }
        }
        public static void Send(string mailText, string subject, string mail)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("vasandrosmail@gmail.com"));
            message.To.Add(new MailboxAddress(mail));
            message.Subject = subject;
            message.Body = new TextPart("plain")
            {
                Text = mailText
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                // Note: since we don't have an OAuth2 token, disable 	// the XOAUTH2 authentication mechanism.     
                client.Authenticate("vasandrosmail@gmail.com", "qwerty1111");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
