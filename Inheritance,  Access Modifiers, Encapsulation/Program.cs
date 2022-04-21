using System;

namespace Inheritance___Access_Modifiers__Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("is","25",false);
            Console.WriteLine(admin.FullName());
        }
    }
}
