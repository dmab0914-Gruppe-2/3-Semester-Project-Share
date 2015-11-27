using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using Library;

namespace Library
{
    #pragma warning disable 0169    // disable never used warnings for fields that are being used by LINQ
    [Table(Name = "User")]
    public class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string Username { get; set; }
        [Column]
        public string Password { get; set; }
        [Column]
        public string Salt { get; set; }
        //[Column]
        public UserType Type { get; set; }
        [Column]
        public string Email { get; set; }

        public User(string username, string password, UserType type)
        {
            Username = username;
            Password = password;
            Type = type;
        }

        public User(int id, string username, string password, UserType type)
        {
            Id = id;
            Username = username;
            Password = password;
            Type = type;
        }

        public User() { }
    }
}
