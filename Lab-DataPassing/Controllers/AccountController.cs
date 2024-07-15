using Lab_DataPassing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Lab_DataPassing.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "kishore" && model.Password == "123456")
                {

                    TempData["Message"] = "Welcome back";

                    string strUser = JsonSerializer.Serialize(model);
                    HttpContext.Session.SetString("User", strUser);

                    return RedirectToAction("Index", "Dashboard");

                }
                else
                {
                    ViewBag.ErrorMessage = "invalid Cred";
                }
            }
            return View();
        }

    
    }
}
