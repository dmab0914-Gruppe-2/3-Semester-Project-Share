using System.Collections.Generic;
using Library;

namespace Server
{
    public interface IProjectController
    {
        ProjectReturnType AddProject(string title, string description, string projectFolder, User projectAdministratorUser);
        ProjectReturnType AddProject(Project project);
        List<Project> GetAllProjects();
        Project GetProject(int id);
        Project[] GetProjectByTitle(string title);
        int DeleteProject(int id);
        bool UpdateProject(int id, string title, string description, string projectFolder, User projectAdministratorUser);
    }
}