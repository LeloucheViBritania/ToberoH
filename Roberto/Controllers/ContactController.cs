using Roberto.DAL;
using Roberto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Roberto.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact()
        {
            //ViewBag.listname = dbobj.ContactSearches.ToList();
            return View();
        }


        //[HttpPost]
        //public ActionResult ContactSearch(string Name)
        //{
        // var obj = from c in dbobj.ContactSearches select c;
        // if (Name != null)
        //{
        //    obj = obj.Where(c => c.Name == Name);
        // ViewBag.name = obj.ToList();
        // }


        // return View();
        // }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Contact(Contact model)
        {

            if (ModelState.IsValid)
            {
                var db = new RobertoContext();

                db.Contacts.Add(new Contact
                {
                    ID = model.ID,
                    SenderName = model.SenderName,
                    SenderEmail = model.SenderEmail,
                    Message = model.Message
                });
                db.SaveChanges();

                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("at193542@gmail.com"));  // replace with valid value 
                message.From = new MailAddress(model.SenderEmail);  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.SenderName, model.SenderEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    var credential = new NetworkCredential
                    {
                        UserName = "at193542@gmail.com",  // replace with valid value
                        Password = "ta0610ami"  // replace with valid value
                    };
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    await smtp.SendMailAsync(message);

                    return RedirectToAction("Contact");
                }


                /*var mail = new MailMessage();
                mail.To.Add(new MailAddress(model.SenderEmail));
                mail.Subject = "Your Email Subject";
                mail.Body = string.Format("<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>", model.SenderName, model.SenderEmail, model.Message);
                mail.IsBodyHtml = true;*/

                /*  using (var smtp = new SmtpClient())
                 {
                     //await smtp.SendMailAsync(mail);
                     return RedirectToAction("SuccessMessage");
                 }*/

            }



            return View(model);
        }

      

    }


}
