using System.Collections.Generic;
using HotelBookingApplicationMVC.Entity;
namespace HotelBookingApplicationMVC.UserRepository
{
    public class Repository
    {
        public static List<User> list = new List<User>();
        static Repository()
        {
            User user = new User("Gowtham", "12345Aa#");
            list.Add(user);
            user = new User("Bhanu", "12345Aa#");
            list.Add(user);
            user = new User("Manju", "12345Aa#");
            list.Add(user);
        }
        public void Add(User user)
        {
            list.Add(user);
        }
    }
}
