using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzopBeadando.BackEnd.Controllers
{
    static class StateController
    {
        private static bool _loggedIn;
        private static bool _isClosed = false;

        public static bool LoggedIn
        {
            get { return _loggedIn; }
            set { _loggedIn = value; }
        }
        public static bool IsClosed
        {
            get { return _isClosed; }
            set { _isClosed = value; }
        }
    }
}
