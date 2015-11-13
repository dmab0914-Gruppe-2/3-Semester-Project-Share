using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public UserType Type { get; set; }

        public User(string userName, string password, UserType type)
        {
            UserName = userName;
            PassWord = password;
            Type = type;
        }

        public User(int id, string userName, string password, UserType type)
        {
            Id = id;
            UserName = userName;
            PassWord = password;
            Type = type;
        }
    }
}
