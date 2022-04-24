using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance___Access_Modifiers__Encapsulation
{
   class Admin : User
    {
        public string Section;
        public bool isSuperAdmin;

        public Admin()
        {

        }
        public Admin(string username, string password, string section, bool SuperAdmin = false) : base(username, password)

        {
            Section = section;
            isSuperAdmin = SuperAdmin;
            
            
         
           
        }
        public string GetInfo()

        {


            return $"Username: {Username} Password: {Password} Section: {Section} Admin: {(isSuperAdmin ? "Siz  Super Adminsiniz" : "Siz Super Admin deyilsiniz")} ";
        }


    }
}

