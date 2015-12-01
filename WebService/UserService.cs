using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server;
using Library;

namespace WebService
{
    
    public class UserService : IUserService
    {
        private static readonly IUserController userController = new UserController();
        public Library.User FindUserById(int id)
        {
            return userController.FindUserById(id);
        }

        public List<User> FindUserByEmail(string email)
        {
            return userController.FindUsersByEmail(email);
        }

        public List<User> FindUserByUsername(string username)
        {
            return userController.FindUsersByUserName(username);
        }

        public List<User> FindAllUsers()
        {
            return userController.FindAllUsers();
        }
    }
}
