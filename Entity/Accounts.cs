using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersLogin_16._04._2024.Entity
{
    public class Accounts
    {
        public User account { get; set; }

        private static Accounts _instance;

        public static Accounts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Accounts();
                return _instance;
            }
        }
    }
}
