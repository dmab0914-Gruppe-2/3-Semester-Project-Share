using System.Collections.Generic;
using Library;

namespace Server
{
    public interface IProjectController
    {
        ProjectReturnType AddProject(string title, string description, string projectFolder, User projectAdministratorUser);
        List<Project> GetAllProjects();
    }
}