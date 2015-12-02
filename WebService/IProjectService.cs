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
    public interface IProjectService
    {
        [OperationContract]
        ProjectReturnType AddProject(string title, string description, string projectFolder, User projectAdministratorUser);
        [OperationContract]
        List<Project> GetAllProjects();

        [OperationContract]
        List<Project> GetProjectByTitle(string title);

        [OperationContract]
        List<Project> GetSomeProjectsBetweenId(int first, int last);
        [OperationContract]
        List<Project> GetSomeProjectsToId(int last);
        [OperationContract]
        Project GetProject(int id);
        [OperationContract]
        bool UpdateProject(int id, string title, string description, string projectFolder);
        [OperationContract]
        bool DeleteProject(int id);
        [OperationContract]
        bool AddUserToProject(int projectId, User user);
        [OperationContract]
        bool RemoveUserFromProject(int projectId, User user);
        [OperationContract]
        bool AddProjectAdministratorToProject(int projectId, User projectAdministrator);
        [OperationContract]
        bool RemoveProjectAdministratorFromProject(int projectId, User projectAdministrator);
        
        
        
    }
}
