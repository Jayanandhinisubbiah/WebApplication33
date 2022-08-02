using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {
        private readonly FoodContext fd;
        public AdminController(FoodContext fd)
        {
            this.fd = fd;
        }

        public IActionResult Index()
        {  
            return View(fd.UserList.ToList());
        }
    }
}
