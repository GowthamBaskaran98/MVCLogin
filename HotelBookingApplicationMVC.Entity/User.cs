using System.ComponentModel.DataAnnotations;

namespace HotelBookingApplicationMVC.Entity
{
    public class User
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string age { get; set; }
        public User(string name, string age)
        {
            this.name = name;
            this.age = age;
        }
        public User()
        {

        }
    }
}
