using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class User
    {
        private int Id { get; set; }
        private string UserName { get; set; }
        private string PassWord { get; set; }
        private UserType Type { get; set; }

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
