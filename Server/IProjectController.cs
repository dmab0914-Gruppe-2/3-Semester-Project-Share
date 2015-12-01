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

        int DeleteProject(int id);

        int UpdateProject();
    }
}