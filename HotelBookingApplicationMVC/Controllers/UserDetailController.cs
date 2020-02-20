using System.Collections.Generic;
using System.Web.Mvc;
using HotelBookingApplicationMVC.Entity;
using HotelBookingApplicationMVC.UserRepository;
namespace HotelBookingApplicationMVC.Controllers
{
    public class UserDetailController : Controller
    {
        Repository repository = new Repository();
        // GET: OnlineLogisticsRegistration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                TryUpdateModel<User>(user);
                repository.Add(user);
            }
            return View();// Redirect("LogIn");

        }
        public ActionResult LogIn()
        {
            return View();
        }
    }
}