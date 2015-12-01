using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Server.Database
{
    interface IDbProject
    {
        bool AddProject(string title, string description, string projectFolder, User projectAdministratorUser);
        bool RemoveProject(int id);
        Project GetProject(int id);
        bool UpdateProject(int id, string title, string description, string projectFolder);
        List<Project> GetAllProjects();
        List<Project> GetProjectByTitle(string title);
        bool AddUserToProject(int projectId, User user);
        bool RemoveUserFromProject(int projectId, User user);
        bool AddProjectAdministratorToProject(int projectId, User projectAdministrator);
        bool RemoveProjectAdministratorFromProject(int projectId, User projectAdministrator);
        bool UpdateProject(int id, string title, string description, string projectFolder, User projectAdministratorUser);
    }
}
