using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class SignInViewModel
    {
        private AuthUser _authUser = new AuthUser();


        public string Login
        {

            get
            {
                return _authUser._login;
            }

            set
            {
                _authUser._login = value;

            }

        }

        public string Password
        {

            get
            {
                return _authUser._password;
            }

            set
            {
                _authUser._password = value;

            }




        }


    }
}
