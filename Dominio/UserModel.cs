using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;

namespace Dominio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        public bool Log(string user, string pass)
        {
            return userDao.Login(user,pass);
        }
    }
}
