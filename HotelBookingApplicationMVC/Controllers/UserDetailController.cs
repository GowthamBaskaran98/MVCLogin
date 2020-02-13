using System.Collections.Generic;
using System.Web.Mvc;
using HotelBookingApplicationMVC.Entity;
using HotelBookingApplicationMVC.UserRepository;
namespace HotelBookingApplicationMVC.Controllers
{
    public class UserDetailController : Controller
    {
        // GET: UserDetail
        public ActionResult Index()
        {
            IEnumerable<User> list = Repository.GetDetails();
            ViewBag.List = list;
            TempData["List"] = list;
            ViewData["List"] = list;
            return View();
        }
    }
}