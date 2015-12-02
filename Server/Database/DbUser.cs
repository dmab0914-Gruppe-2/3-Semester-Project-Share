using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Database
{
    class DbUser : IDbUser
    {
        private DbContext dbContext;

        public DbUser()
        {
            dbContext = new DbContext();
        }
        public Library.User FindUserById(int id)
        {
            return dbContext.Users.FirstOrDefault(i => i.Id == id);
        }

        public List<User> FindUsersByEmail(string email)
        {
            return dbContext.Users.Where(i => i.Email.Contains(email)).ToList();
        }

        public List<User> FindUsersByUserName(string username)
        {
            return dbContext.Users.Where(i => i.Username.Contains(username)).ToList();
        }

        public List<User> FindAllUsers()
        {
            return dbContext.Users.ToList();
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
