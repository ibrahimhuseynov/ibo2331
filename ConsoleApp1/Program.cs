using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User users = new User();
            users.Fullname = "ibrahimhuseynovhuseynov";
            users.Password = "Aahzmhgfd1";
            users.Email = "huseynov@gmail.com";
            Console.WriteLine(users.ShowInfo());
            Console.WriteLine(users.PaswordChecker());
            Console.ReadLine();
        }
    }
}
