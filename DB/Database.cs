using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersLogin_16._04._2024.Entity;

namespace UsersLogin_16._04._2024.DB
{
    public  class Database
    {
        private static Database _instance;

        public static Database  Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Database();
                return _instance;
            }
        }

        private Database()
        {
            
        }
        public List<User> users = new List<User>()
        {
            new User()
            {
                Name="admin",
                Password="admin",
            }
        };
    }
}
