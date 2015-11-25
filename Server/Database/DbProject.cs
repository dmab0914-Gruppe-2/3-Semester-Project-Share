using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Database
{
    class DbProject : IDbProject
    {
        int IDbProject.AddProject(string title, string description, string projectFolder, Library.User projectAdministratorUser)
        {
            throw new NotImplementedException();
        }

        int IDbProject.RemoveProject(int id)
        {
            throw new NotImplementedException();
        }

        Library.Project IDbProject.GetProject(int id)
        {
            throw new NotImplementedException();
        }

        int IDbProject.UpdateProject(int id, string title, string description, string projectFolder, Library.User projectAdministratorUser)
        {
            throw new NotImplementedException();
        }

        List<Library.Project> IDbProject.GetAllProjects()
        {
            throw new NotImplementedException();
        }
    }
}
