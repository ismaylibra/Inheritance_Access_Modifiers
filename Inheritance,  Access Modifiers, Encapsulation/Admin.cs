using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance___Access_Modifiers__Encapsulation
{
   class Admin : User
    {
        public string Section;


        bool isSuperAdmin;
        public Admin(string username, string password, bool isSuperAdmin, string section):base(username, password)
           
        {
            Section = section;
            Console.WriteLine(Section);
            if (isSuperAdmin)
            {
                Console.WriteLine("Siz Super Adminsiniz");
            }  else
            {
                Console.WriteLine("Siz Super Admin deyilsiniz");
            }
            
        }
      
    }
}

