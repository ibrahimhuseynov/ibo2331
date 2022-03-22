using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class User : IAccount

    {
        public string Fullname;
        public string Email;
        public string Password;
        public string pasport()
        {
            if (PaswordChecker(Password))
            {
                return Password;
            }
            return "passporti duzgun daxil e";
        }
        public bool PaswordChecker()
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (hasdig(pasport()) && haslav(pasport()) && hasUpp(pasport()) && haslench(pasport()))
                {
                    return true;

                }
            }
            return false;
        }

        public bool haslench(string Password)
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (Password.Length >= 8)
                {
                    return true;
                }

            }
            return false;
        }
        public bool hasUpp(string Password)
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (char.IsUpper(Password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool hasdig(string Password)
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (char.IsDigit(Password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool haslav(string Password)
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (char.IsLower(Password[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool PaswordChecker(string passport)
        {
            return true;
        }

        public string ShowInfo()
        {
            return ("fullname :" + Fullname + "   " + "email :" + Email);
        }
    }
}

