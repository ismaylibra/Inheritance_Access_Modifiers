using System;

namespace Inheritance___Access_Modifiers__Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        { string username;
            Admin admin = new Admin("ismayil","Ismayil123",true,"programming" );


            do
            {
                Console.WriteLine("Username-i  daxil edin: ");
                username = Console.ReadLine();
                

                
            } while (username.Length<6);
            string password;
            do    
            {
                Console.WriteLine("Password-u  daxil edin: ");
                password = Console.ReadLine();
                Console.WriteLine(admin.Code(password));
            } while (password.Length<8);
           
            Console.WriteLine(admin.FullName());

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
                    if (char.IsDigit(letter))
                    {
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
                }
                bool result = isDigit && isUpper && isLower;
                return result;
            }
            return false;
        }
    }
}
