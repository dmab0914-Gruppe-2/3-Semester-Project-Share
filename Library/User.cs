using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace Library
{
    [Table(Name = "User")]
    public class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string UserName { get; set; }
        [Column]
        public string PassWord { get; set; }
        [Column]
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
