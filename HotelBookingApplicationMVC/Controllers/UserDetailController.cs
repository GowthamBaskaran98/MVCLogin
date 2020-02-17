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
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            User user = new User();
            //UpdateModel<User>(user);
            TryUpdateModel<User>(user);
            repository.AddCustomer(user);
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