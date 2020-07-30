using Roberto.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roberto.Controllers
{
    public class DashboarController : Controller
    {
        // GET: Dashboar

        RobertoContext dbobj = new RobertoContext();
        public ActionResult Dashboar()
        {
            ViewBag.listname = dbobj.Contacts.ToList();
            return View();
        }


      /*  public ActionResult Login()
        {

            return this.View();

        }*/

/*
        [HttpPost]
        public ActionResult Logins(LoginModels loginModels, string returnUrl)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(loginModels);
            }


            if (Membership.ValidateUser(loginModels.Email, loginModels.MotDePasse))
            {
                FormsAuthentication.SetAuthCookie(loginModels.Email, loginModels.LoginId);
                if (this.Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return this.Redirect(returnUrl);
                }

                return this.RedirectToAction("Dashboar", "Dashboar");
            }

            this.ModelState.AddModelError(string.Empty, "The user name or password provided is incorrect.");

            return this.View(loginModels);




        }*/

    }
}