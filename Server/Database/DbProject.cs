using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Server.Database
{
    public class DbProject : IDbProject
    {
        private DbContext dbContext;
        public DbProject()
        {
             dbContext = new DbContext();
        }

        bool IDbProject.AddProject(string title, string description, string projectFolder, Library.User projectAdministratorUser)
        {
            throw new NotImplementedException();
        }

        bool IDbProject.RemoveProject(int id)
        {
            Project project = ((IDbProject) this).GetProject(id);
            if (project != null)
            {
                try
                {
                    dbContext.Projects.DeleteOnSubmit(project);
                    dbContext.SubmitChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        Library.Project IDbProject.GetProject(int id)
        {
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
            return dbContext.Projects.ToList();
        }
    }
}
