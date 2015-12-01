using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Database;

namespace Server
{
    public class UserController : IUserController
    {
        private readonly IDbUser _dbUser = new DbUser();
        public Library.User FindUserById(int id)
        {
            return _dbUser.FindUserById(id);
            
        }

        public Library.User[] FindUsersByEmail(string email)
        {
            return _dbUser.FindUsersByEmail(email);
        }

        public Library.User[] FindUsersByUserName(string username)
        {
            return _dbUser.FindUsersByUserName(username);
        }

        public Library.User[] FindAllUsers()
        {
            return _dbUser.FindAllUsers();
        }
    }
}
