using System.Collections.Generic;
using System.Web.Mvc;
using HotelBookingApplicationMVC.Entity;
using HotelBookingApplicationMVC.UserRepository;
namespace HotelBookingApplicationMVC.Controllers
{
    public class UserDetailController : Controller
    {
        Repository repository = new Repository();
        public ViewResult Index()
        {

            IEnumerable<User> user = repository.Display();
            return View(user);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User restaurantEntity)
        {
            repository.AddCustomer(restaurantEntity);
            TempData["Message"] = "User Added Successfully";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string name)
        {
            User user = repository.GetDetail(name);
            return View(user);
        }
        public ActionResult Delete(string name)
        {
            repository.Delete(name);
            TempData["Message"] = "User details deleted";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update(User user)
        {
            repository.Update(user);
            TempData["Message"] = "User Updated successfully";
            return RedirectToAction("Index");
        }
    }
}