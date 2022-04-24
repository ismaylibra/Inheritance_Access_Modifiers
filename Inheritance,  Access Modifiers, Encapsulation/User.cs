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
                return _uname;

            }
            set
            {

                if (value.Length > 6)
                {
                    _uname = value;
                }
                else
                {
                    Console.WriteLine("Username-i yeniden daxil edin");
                    Console.WriteLine("Username minimum 6 xarakterden ibraret olmalidir");
                }

            }
        }
       
        public User()
        {

        }
        public string Password
        {
            get
            {
                return _pword;
            }
            set
            {

                if (Code(value)) 
                {
                    _pword = value;
                }
                else
                {
                   
                    Console.WriteLine("Password minimum 8 xarakterden ibaret olmalidir");
                }
            }
        }
        public User(string username, string password)
        {
            
            Username = username;
            Password = password;
        }
        
      
        public bool Code(string pword)
        {
            bool isDigit = false;
            bool isUpper = false;
            bool isLower = false;
            if (pword.Length > 8)
            {
                foreach (char letter in pword)
                {
                    if (char.IsDigit(letter)) {
                        isDigit = true;
                    }
                    else if (char.IsUpper(letter))
                    {
                        isUpper = true;
                    }
                    else if (char.IsLower(letter))
                    {
                        isLower = true;
                    }
                }    bool result = isDigit && isUpper && isLower;
                return result;
            }
            return false;
        }

    }
}
