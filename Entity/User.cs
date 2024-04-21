using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersLogin_16._04._2024.Entity
{
    public class User:BaseEntity
    {
        public string Name { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
