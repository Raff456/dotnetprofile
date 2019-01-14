using System;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;

namespace netcoremain.Controllers
{
  public class ContactController : Controller
  {
    public ActionResult Index()
    {
        return View();
    }


    [HttpPost]
    public ActionResult Sendmessage(Models.SendMail objMail)
    {
      if(ModelState.IsValid)
      {
        string to = "canticchiando456@gmail.com"; //example:- sourabh9303@gmail.com
        MailMessage mail = new MailMessage();
        SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);

              
            mail.From = new MailAddress(objMail.FromEmail, "CTMIS-no-reply");
            mail.To.Add(new MailAddress("canticchiando456@gmail.com"));
            mail.Subject = "contact";
            mail.Body = objMail.FromName+";"+ objMail.FromEmail+";"+objMail.Body;
            mail.IsBodyHtml = false;

            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            NetworkCredential networkCredential = new NetworkCredential(to, "great_purpose123");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = networkCredential;
            try
            {
              smtp.Send(mail);
            }
            catch (Exception ex)
            {
              objMail.Body = "Send is failed: "+ex.Message;
            }

            return View("Index", objMail);               
      }
      
       return View();
            
    }
      
  }
}