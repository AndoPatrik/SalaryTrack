using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryTrack.Helpers
{
    static class SignUpHelper
    {
        public static bool PasswordValidation(string password , string password2)
        {
            if (password != password2)
            {
                return false;
            }
            return true;
        }
    }
}
