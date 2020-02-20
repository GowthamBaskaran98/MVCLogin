using System.ComponentModel.DataAnnotations;

namespace HotelBookingApplicationMVC.Entity
{
    public enum UserType
    {
        HotelOwner,
        Customer
    }
    public class User
    {
        //[Required]
        //public string name { get; set; }
        //[Required]
        //public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long mobileNumber { get; set; }
        public string gmail { get; set; }
        public string password { get; set; }
        public UserType userType { get; set; }
        public User(string firstName, string lastName, long mobileNumber, string gmail, string password, string userType)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNumber = mobileNumber;
            this.gmail = gmail;
            this.password = password;
        }
        public User(string gmail, string password)
        {
            this.gmail = gmail;
            this.password = password;
        }
        public User()
        {

        }
    }
}
