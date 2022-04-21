using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance___Access_Modifiers__Encapsulation
{
   class Admin : User
    {


        bool isSuperAdmin;
        public Admin(string username, string password, bool isSuperAdmin):base(username, password)
        {
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

