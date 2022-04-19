using classwork.interface1;
using System;
using System.Collections.Generic;
using System.Text;

namespace classwork.models
{
    class user:accoun
    {
        public string Fullname;
        public string Email;
        public string Password;

        public bool Passwordchecker(string password)
        {
            bool check = false;
            bool checker = false;
            while (check)
            {
                bool checkLower = false;
                bool checkUpper = false;
                bool checkDigit = false;

                if (password.Length >= 8)
                {
                    foreach (char item in password)
                    {
                        if (char.IsUpper(item))
                        {
                            checkUpper = true;
                        }
                        else if (char.IsLower(item))
                        {
                            checkLower = true;
                        }
                        else if (char.IsDigit(item))
                        {
                            checkDigit = true;
                        }

                        if (checkLower == true && checkUpper && checkDigit)
                        {
                            Password = password;
                            checker = true;
                            check = false;
                            break;
                        }
                    }

                    if (checkDigit == false || checkLower == false || checkUpper == false)
                    {
                        checker = false;
                        check = false;
                    }
                }
                else
                {
                    checker = false;
                    check = false;
                }
            }
            return checker;
        }
    }
}
