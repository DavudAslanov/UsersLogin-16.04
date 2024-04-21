using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersLogin_16._04._2024.Entity;

namespace UsersLogin_16._04._2024.Cocrete
{
    public interface IuserManager<T> where T : BaseEntity ,new()
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAll();
    }
}
