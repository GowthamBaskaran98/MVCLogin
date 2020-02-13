using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingApplicationMVC.Entity;
namespace HotelBookingApplicationMVC.UserRepository
{
    public class Repository
    {
        public static List<User> list = new List<User>();
        static Repository()
        {
            list.Add(new User { mailId = "gowthambas98@gmail.com", password = "8903940293" });
        }
        public static IEnumerable<User> GetDetails()
        {
            return list;
        }
    }
}
