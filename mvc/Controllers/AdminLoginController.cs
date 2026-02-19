using Microsoft.AspNetCore.Mvc;
using mvc.Models.UIMODELS;

namespace mvc.Controllers
{
    public class AdminLoginController : Controller
    {
        [HttpGet]
        public IActionResult AdmLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdmLogin(MCustomer model)
        {
            string Email = "v@g.com";
            string password = "1234";
            if (ModelState.IsValid) {
                var res = model.Email == Email && model.password == password;
                if (res == true)
                {
                    return RedirectToAction("Index", "Home");
                }


            }
            return View();
        }

    }
}
