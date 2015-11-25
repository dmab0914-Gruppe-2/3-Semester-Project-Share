using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Library;
using Server.Database;

namespace Server
{
    public class ProjectController : IProjectController
    {
        private readonly IDbProject _dbProject = new DbProject();
        public ProjectReturnType AddProject(string title, string description, string projectFolder, User projectAdministratorUser)
        {
            if (title == null || title.Equals(""))
            {
                return ProjectReturnType.TitleMissing;
            }
            else if (description == null || description.Equals(""))
            {
                return ProjectReturnType.DescriptionMissing;
            }
            else if (projectFolder == null || projectFolder.Equals(""))
            {
                return ProjectReturnType.ProjectFolderMissing;
            }
            else if (projectAdministratorUser == null)
            {
                return ProjectReturnType.ProjectAdministratorUserMissing;
            }

            Project project = new Project(title, description, projectFolder, projectAdministratorUser);
            _dbProject.AddProject(project.Title, project.Description, project.ProjectFolder, projectAdministratorUser);
            return ProjectReturnType.Success;
            //return ProjectReturnType.Success;
            //throw new NotImplementedException();
        }

        public List<Project> GetAllProjects()
        {
            return _dbProject.GetAllProjects();
        }

    }

}