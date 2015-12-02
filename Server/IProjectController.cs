using System;
using System.Collections.Generic;
using Library;

namespace Server
{
    public interface IProjectController
    {
        ProjectReturnType AddProject(string title, string description, string projectFolder, User projectAdministratorUser);
        ProjectReturnType AddProject(Project project);
        List<Project> GetAllProjects();
        List<Project> GetProjectByTitle(string title);
        Project GetProject(int id);
        bool DeleteProject(int id);
        bool UpdateProject(int id, string title, string description, string projectFolder);
        bool AddUserToProject(int projectId, User user);
        bool RemoveUserFromProject(int projectId, User user);
        bool AddProjectAdministratorToProject(int projectId, User projectAdministrator);
        bool RemoveProjectAdministratorFromProject(int projectId, User projectAdministrator);

    }
}