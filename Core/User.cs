using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class User
    {

        public  long Id
        {
            get
            {
                return _id;
            }
        }

        public string Login
        {
            set
            {
                _login = value;
            }
            get
            {
                return _login;
            }
        }

        public string Password
        {

            set
            {
                _password = value;

            }
            get
            {
                return _password; 
            }
        }

        private string _password;

        private long _id;

        private string _login;
    }
}
