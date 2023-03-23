using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyClassLibrary
{
    public class UserAccount
    {
        // Fields
        string _username;
        string _password;

        // Constructors
        public UserAccount(string username, string password)
        {
            _username = username;
            _password = password;
        }

        // Properties
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }


        // Method Modifiers (Virtual, New, Override)
        public override string? ToString()
        {
            return $"{_username} - {_password}";
        }
    }
}
