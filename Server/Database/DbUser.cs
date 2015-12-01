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
    }
}
