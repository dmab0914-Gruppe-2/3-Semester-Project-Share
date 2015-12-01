using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server;

namespace WebService
{
    
    public class UserService : IUserService
    {
        private static readonly IUserController userController = new UserController();
        public Library.User FindUserById(int id)
        {
            return userController.FindUserById(id);
        }

        public Library.User[] FindUserByEmail(string email)
        {
            return userController.FindUsersByEmail(email);
        }

        public Library.User[] FindUserByUsername(string username)
        {
            return userController.FindUsersByUserName(username);
        }

        public Library.User[] FindAllUsers()
        {
            return userController.FindAllUsers();
        }
    }
}
