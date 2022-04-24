using System;

namespace Inheritance___Access_Modifiers__Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            User user = new User();
            string username;

            do
            {
                Console.WriteLine("Username-i  daxil edin: ");
                username = Console.ReadLine();



            } while (username.Length<6);
            string pword;
            
            do    
            {
                Console.WriteLine("Password-u  daxil edin: ");
                pword = Console.ReadLine();
                
            } while (!user.Code(pword));
            Console.WriteLine("Section daxil edin: ");
            string section = Console.ReadLine();
            Console.WriteLine("Siz Super Adminsiniz ?");
            string  isSuperAdm = Console.ReadLine();
            bool isSuper = false;

            if (isSuperAdm.ToLower() == "beli")
            {
                isSuper = true;

            }
            else if (isSuperAdm.ToLower() == "xeyr")
            {
                isSuper = false;
            }
            Admin admin1 = new Admin(username, pword, section, isSuper);
            Console.WriteLine(admin1.GetInfo());
        }

       
    }
}
