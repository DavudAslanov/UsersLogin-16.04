using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersLogin_16._04._2024.Entity
{
    public class Validation
    {

        public delegate bool ValidationDelegate(User user);
        static ValidationDelegate MyNamevalidation = Name1;
        static ValidationDelegate Myemailvalidation=Email1;
        static ValidationDelegate Mypasswordvalidation = Password1;
        public static bool validationHandler(User user,params ValidationDelegate[] validations)
        {
            foreach(ValidationDelegate validation in validations)
            {
                if(!validation(user))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidationTrue(User user)
        {
            bool result=validationHandler(user,Name1,Email1,Password1);
            if(result)
            {
                return true;
            }
            return false;

        }
        public static bool Name1(User user)
        {
            if (user.Name.Length >= 3)
            {
                return true;
            }
            return false;
        }

        public static bool Email1(User user)
        {
            if (!user.Email.Contains('@'))
            {
                return false;
            }
            return true;
        }

        public static bool Password1(User user)
        {
            if (user.Password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        //public static bool MyValidation(User user)
        //{
        //    if(!Name(user.Name))
        //    {
        //        return false;
        //    }
        //    if(!Email(user.Email))
        //    {
        //        return false;
        //    }
        //    if(!Password(user.Password))
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        //public static bool Name(string name)
        //{
        //    if (name.Length >= 3)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public static bool Email(string name)
        //{
        //    if(!name.Contains('@'))
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //public static bool Password(string name)
        //{
        //    if(name.Length >= 8)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

    }
}
