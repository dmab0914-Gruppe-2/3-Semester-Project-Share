using Library;
using System.Collections.Generic;

namespace Server.Database
{
    public interface IDbUser
    {

        //Create
        bool AddUser(int id, string username, string password, string salt, UserType usertype, string email); //TODO Add later
        //Read
        User FindUserById(int id);
        List<User> FindUsersByEmail(string email); //Ment som email substring, listen kan bare indeholde 1 user hvis der kun findes 1 user
        List<User> FindUsersByUserName(string username); //Ment som substring, listen kan bare indeholde 1 user hvis der kun er 1
        List<User> FindAllUsers();
        //Update
        bool UpdateUser(int id, string username, string password, string salt, UserType usertype, string email); //TODO Add later
        //Delete
        bool DeleteUser(int id);
    }
}