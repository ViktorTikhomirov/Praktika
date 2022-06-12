using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    internal class User
    {
        private string name;
        private string surname;
        private string email;
        private string password;
        private string phoneNumber;
        private string gender;
        private string country;
        private DateTime dateOfBirth; 

        public static User Instance { get; private set; } 

        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public string Email { get { return email; } }
        public string Password { get { return password; } }
        public string PhoneNumber { get { return phoneNumber; } }
        public string Gender { get { return gender; } }
        public string Country { get { return country; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } }

        public User(string _Name, string _Surname)
        {

        }
    }
    internal struct UserData
    {

    }
}
