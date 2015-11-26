using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Server.Database
{
    class DbProject : IDbProject
    {
        bool IDbProject.AddProject(string title, string description, string projectFolder, Library.User projectAdministratorUser)
        {
            throw new NotImplementedException();
        }

        bool IDbProject.RemoveProject(int id)
        {
            throw new NotImplementedException();
        }

        Library.Project IDbProject.GetProject(int id)
        {
            DbContext dbContext = new DbContext();
            var item = dbContext.Projects.First(i => i.Id == id);
            if (item != null)
            {
                return item;
            }
            return null;
        }

        bool IDbProject.UpdateProject(int id, string title, string description, string projectFolder, Library.User projectAdministratorUser)
        {
            throw new NotImplementedException();
        }

        List<Library.Project> IDbProject.GetAllProjects()
        {
            throw new NotImplementedException();
        }
    }
}
