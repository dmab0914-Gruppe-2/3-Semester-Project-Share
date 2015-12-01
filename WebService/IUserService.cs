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
        Library.User[] FindUserByEmail(string email);

        [OperationContract]
        Library.User[] FindUserByUsername(string username);

        [OperationContract]
        Library.User[] FindAllUsers();
    }
}
