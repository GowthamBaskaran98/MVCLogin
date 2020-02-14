namespace HotelBookingApplicationMVC.Entity
{
    public class User
    {
        public string name { get; set; }
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
