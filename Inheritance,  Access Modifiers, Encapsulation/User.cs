using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance___Access_Modifiers__Encapsulation
{
    class User
    {

        string _uname;
        string _pword;

        public string Username
        {
            get
            {
                return Username;

            }
            set
            {

                if (value.Length > 6)
                {
                    value = _uname;
                }
                else
                {
                    Console.WriteLine("Username-i yeniden daxil edin");
                    Console.WriteLine("Username minimum 6 xarakterden ibraret olmalidir");
                }

            }
        }
        public string Password
        {
            get
            {
                return _pword;
            }
            set
            {

                if (value.Length > 8)
                {
                    value = _pword;
                }
                else
                {
                    Console.WriteLine("Password-u yeniden daxil edin");
                    Console.WriteLine("Password minimum 8 xarakterden ibaret olmalidir");
                }
            }
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public string FullName()
        {
            return $"Username: {Username} Password: {Password}";
        }
      


    }
}
