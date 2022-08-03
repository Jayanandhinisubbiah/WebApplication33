using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class LoginController : Controller
    {
        private readonly FoodContext fd;
        private readonly ISession session;
        public LoginController(FoodContext fd, IHttpContextAccessor httpContextAccessor)
        {
            this.fd = fd;
            session = httpContextAccessor.HttpContext.Session;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(UserList U)
        {
            fd.UserList.Add(U);
            fd.SaveChanges();
            if (U.Role == "Admin")
                return RedirectToAction("Index", "User");
            else
                return RedirectToAction("Index", "Foods");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserList U)
        {

            var result = (from i in fd.UserList
                          where i.FName == U.FName && i.Password == U.Password && i.Role == U.Role
                          select i).SingleOrDefault();
            HttpContext.Session.SetString("UserId", result.UserId.ToString());
            if (U.Role == "Admin")
            {

                return RedirectToAction("Index", "User");
            }
            else if (U.Role == "User")
            {
                //HttpContext.Session.SetString("UserId", result.UserId.ToString());
                return RedirectToAction("Index", "Foods");
            }
            else
                return RedirectToAction("Login", "Login");


        }
    }
}
