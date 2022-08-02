using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        private readonly FoodContext fd;
        public UserController(FoodContext fd)
        {
            this.fd = fd;
        }

        public IActionResult Index()
        {
            return View(fd.UserList.ToList());
        }
        public IActionResult ViewReport(int UserId)
        {
            var result = (from i in fd.OrderMaster
                          where i.UserId == UserId
                          select i).SingleOrDefault();
            if (result != null)
            {
                var res = (from i in fd.OrderDetail.Include(x => x.Food)
                           where i.OrderId == result.OrderId
                           select i).ToList();
                return View(res);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        public IActionResult ViewPayReport(int UserId)
        {
            var result = (from i in fd.OrderMaster
                          where i.UserId == UserId
                          select i).SingleOrDefault();
            if (result != null)
            {
                return View(result);
            }
            else
            {
                return RedirectToAction("Index");

            }
        }
    }
}
