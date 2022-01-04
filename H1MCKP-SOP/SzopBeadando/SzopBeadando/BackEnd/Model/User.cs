using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzopBeadando.BackEnd.Model
{
    static class User
    {
        private static int id;
        private static string username;
        private static string pwd;


        public static string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }


        public static string UserName
        {
            get { return username; }
            set { username = value; }
        }


        public static int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
