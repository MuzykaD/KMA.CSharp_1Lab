using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public class AuthService
    {
        public User Authenticate(AuthUser auth)
        {
            
            return new User("Test", "test", "@gmail", "login");
        }


    }
}
