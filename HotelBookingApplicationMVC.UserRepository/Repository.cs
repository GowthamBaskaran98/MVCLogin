using System.Collections.Generic;
using HotelBookingApplicationMVC.Entity;
namespace HotelBookingApplicationMVC.UserRepository
{
    public class Repository
    {
        public static List<User> list = new List<User>();
        static Repository()
        {
            User user = new User("Gowtham","22");
            list.Add(user);
            user = new User("Bhanu", "22");
            list.Add(user);
            user = new User("Manju", "22");
            list.Add(user);
        }
        public IEnumerable<User> Display()
        {
            return list;
        }
        public void AddCustomer(User user)
        {
            list.Add(user);
        }
        public User GetDetail(string name)
        {
            return list.Find(id => id.name == name);
        }
        public void Delete(string name)
        {
            User user = GetDetail(name);
            if (user != null)
            {
                list.Remove(user);
            }
        }
        public void Update(User entity)
        {
            User user = GetDetail(entity.name);
            user.name = entity.name;
            user.age = entity.age;
        }
    }
}
