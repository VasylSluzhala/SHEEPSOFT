using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CompanyPage.Helpers;
using CompanyPage.ViewModel;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace CompanyPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public ActionResult ContactUs(ContactUsViewModel model)
        {
            try
            {
                var mailText = $"From : {model.Name} {model.Email}" +
                               Environment.NewLine +
                               $"{model.Message}";
                var subject = "New contact us answer";
                var mails = new List<string>()
            {
                "schepanskiy1994@gmail.com",
                "roshom68@gmail.com",
                "mu.1.chested.09@gmail.com"
            };

                MailHelper.Send(mailText, subject, mails);
            }
            catch (Exception e)
            {

                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Shit");
            }
            return Json(null);
        }


    }
}
