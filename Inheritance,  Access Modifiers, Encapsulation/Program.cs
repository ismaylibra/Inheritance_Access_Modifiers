using System;

namespace Inheritance___Access_Modifiers__Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        { string username;
           
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
            } while (password.Length<8);
            Admin admin = new Admin("ismayil","Ismayil25",true,"programming");
            Console.WriteLine(admin.FullName());
        }
    }
}
