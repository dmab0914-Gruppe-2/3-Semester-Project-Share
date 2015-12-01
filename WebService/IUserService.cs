using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        Library.User FindUserById(int id);

        [OperationContract]
        List<User> FindUserByEmail(string email);

        [OperationContract]
        List<User> FindUserByUsername(string username);

        [OperationContract]
        List<User> FindAllUsers();
    }
}
