using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RegisterMVC.Models;
using System.Web.Mvc;
using System.Net.Http;

namespace RegisterMVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index(string Response)
        {
            if (Response == "S")
            {
                ViewBag.Message = "Success Registered!";
            }

            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(RegisterModel Register)
        {
            HttpResponseMessage responseMessage = Globalvariables.WebAPIClient.PostAsJsonAsync("Register", Register).Result;
            if (!responseMessage.IsSuccessStatusCode)
            {
                return View();
            }
            return RedirectToAction("Index", new { Response = "S" });
        }
    }
}