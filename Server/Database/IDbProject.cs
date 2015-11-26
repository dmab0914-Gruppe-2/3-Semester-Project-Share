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
        bool UpdateProject(int id, string title, string description, string projectFolder, User projectAdministratorUser);
        List<Project> GetAllProjects();

    }
}
