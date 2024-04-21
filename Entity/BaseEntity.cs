using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersLogin_16._04._2024.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public static int _id=1;

        public BaseEntity()
        {
            Id = _id++;
        }

    }
}
