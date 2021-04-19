using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Tools;
using WpfApp1.Tools.Managers;

namespace WpfApp1
{
    public class AuthService
    {
        

        public User Authenticate(AuthUser auth)
        {
            return StationManager.Instance.DataStorage.AuthenticateUser(auth);
        }


    }
}
