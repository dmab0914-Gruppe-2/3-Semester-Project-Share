﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Server
{
    public interface IUserController
    {
        User FindUserById(int id);
        List<User> FindUsersByEmail(string email); //Ment som email substring, listen kan bare indeholde 1 user hvis der kun findes 1 user
        List<User> FindUsersByUserName(string username); //Ment som substring, listen kan bare indeholde 1 user hvis der kun er 1
        List<User> FindAllUsers();
    }
}
