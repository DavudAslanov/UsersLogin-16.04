using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersLogin_16._04._2024.Cocrete;
using UsersLogin_16._04._2024.DB;

namespace UsersLogin_16._04._2024.Entity
{
    public class UserManager : IuserManager<User>
    {
        public void Add(User entity)
        {
            Database.Instance.users.Add(entity);
        }

        public List<User> GetAll()
        {
            return Database.Instance.users;
        }

        public void Update(User entity)
        {
            //var a = Database.Instance.users.Where(x => x.Id==entity.Id).FirstOrDefault();
            var a = Database.Instance.users.Find(x => x.Name == entity.Name);

            if (a != null)
            {
                a.Name = entity.Name;
                a.Email = entity.Email;
                a.Password = entity.Password;
                a.Email = entity.Email;
                a.FirstName=entity.FirstName;
            }

        }

        public void Delete(User entity)
        {
            var a = Database.Instance.users.Find(x => x.Name == entity.Name);
            Database.Instance.users.Remove(a);

        }
    }
}
