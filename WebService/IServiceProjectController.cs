using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Library;

namespace WebService
{

    [ServiceContract]
    public interface IServiceProjectController
    {
        [OperationContract]
        ProjectReturnType AddProject(string title, string description, string projectFolder, User projectAdministratorUser);

        [OperationContract]
        List<Project> GetAllProjects();
    }
}
