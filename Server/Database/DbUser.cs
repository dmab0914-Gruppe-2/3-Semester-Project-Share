using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Database
{
    class DbUser : IDbUser
    {
        public Library.User FindUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Library.User[] FindUsersByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Library.User[] FindUsersByUserName(string username)
        {
            throw new NotImplementedException();
        }

        public Library.User[] FindAllUsers()
        {
            throw new NotImplementedException();
        }

        public bool AddUser(int id, string username, string password, string salt, Library.UserType usertype, string email)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(int id, string username, string password, string salt, Library.UserType usertype, string email)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
