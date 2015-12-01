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

        public ProjectReturnType AddProject(Project project)
        {
            if (project.Title == null || project.Title.Equals(""))
            {
                return ProjectReturnType.TitleMissing;
            }
            else if (project.Description == null || project.Description.Equals(""))
            {
                return ProjectReturnType.DescriptionMissing;
            }
            else if (project.ProjectFolder == null || project.ProjectFolder.Equals(""))
            {
                return ProjectReturnType.ProjectFolderMissing;
            }
            else if (project.ProjectAdministrators.Count == 0)
            {
                return ProjectReturnType.ProjectAdministratorUserMissing;
            }
            _dbProject.AddProject(project.Title, project.Description, project.ProjectFolder, project.ProjectAdministrators.FirstOrDefault());
            return ProjectReturnType.Success;
            //throw new NotImplementedException();
        }

        public List<Project> GetAllProjects()
        {
            return _dbProject.GetAllProjects();
        }


        public Project GetProject(int id)
        {
            return _dbProject.GetProject(id);
        }

        public Project[] GetProjectByTitle(string title)
        {
            return _dbProject.GetProjectByTitle(title);
        }

        public int DeleteProject(int id)
        {
            throw new NotImplementedException();
            //return _dbProject.DeleteProject(id);
        }

        public bool UpdateProject(int id, string title, string description, string projectFolder, User projectAdministratorUser)
        {
            return _dbProject.UpdateProject(id, title, description, projectFolder, projectAdministratorUser);
        }
    }

}