using Library;

namespace Server.Database
{
    public interface IDbUser
    {

        //Create
        //bool AddUser(int id, string username, string password, string salt, UserType usertype, string email); //TODO Add later
        //Read
        User FindUserById(int id);
        User[] FindUsersByEmail(string email); //Ment som email substring, listen kan bare indeholde 1 user hvis der kun findes 1 user
        User[] FindUsersByUserName(string username); //Ment som substring, listen kan bare indeholde 1 user hvis der kun er 1
        User[] FindAllUsers();
        //Update
        //bool UpdateUser(int id, string username, string password, string salt, UserType usertype, string email); //TODO Add later
        //Delete
        //bool DeleteUser(int id); //TODO Add later

        //public int Id 
        //public string Username 
        //public string Password 
        //public string Salt 
        //public UserType Type 
        //public string Email
    }
}