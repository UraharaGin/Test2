using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Test.Domain;
using Test.Test.Models;
using Test.Test.Tools;

namespace Test.Test.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthentificator _authentificator;

        public AccountController(IAuthentificator authentificator)
        {
            _authentificator = authentificator;
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Password = model.Password,
                    UserName = model.UserName
                };
                try
                {
                    _authentificator.RegisterUser(user);
                }
                catch (UserAlreadyExist)
                {
                    return View(model);
                }

                return RedirectToAction("Okey");
            }
            return View(model);
        }

        public string Okey()
        {
            return "okey!";
        }

    }
}
