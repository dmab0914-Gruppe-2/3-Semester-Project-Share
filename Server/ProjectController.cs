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
        private readonly IDbProject _dbProject;
        private readonly IUserController _userController;

        public ProjectController()
        {
            _dbProject = new DbProject();
            _userController = new UserController();
        }

        public ProjectReturnType AddProject(string title, string description, string projectFolder,
            User projectAdministratorUser)
        {
            if (title == null || title.Equals("") || !System.Text.RegularExpressions.Regex.IsMatch(title, @"^[a-zA-Z\d\s]{1,40}$"))
            {
                return ProjectReturnType.TitleMissing;
            }
            else if (description == null || description.Equals("") || !System.Text.RegularExpressions.Regex.IsMatch(description, @"^[a-zA-Z\d\s\,\.\-\?\&\+\@\#\*\(\)\;\:\/]{1,500}$"))
            {
                return ProjectReturnType.DescriptionMissing;
            }
            else if (projectFolder == null || projectFolder.Equals("")/* || !System.Text.RegularExpressions.Regex.IsMatch(projectFolder, @"^[a-zA-Z\d]$")*/)
            {
                return ProjectReturnType.ProjectFolderMissing;
            }
            else if (projectAdministratorUser == null/* || !System.Text.RegularExpressions.Regex.IsMatch(title, @"^[a-zA-Z\d\s]{1,40}$")*/)
            {
                return ProjectReturnType.ProjectAdministratorUserMissing;
            }
            else if (_userController.FindUserById(projectAdministratorUser.Id) == null)
            {
                return ProjectReturnType.ProjectAdministratorUserMissing;
            }
            else if (_dbProject.AddProject(title, description, projectFolder, projectAdministratorUser))
            {
                return ProjectReturnType.Success;
            }
            else
            {
                return ProjectReturnType.IdMissing;
            }
        }

        public List<Project> GetAllProjects()
        {
            return _dbProject.GetAllProjects();
        }


        public Project GetProject(int id)
        {
            return _dbProject.GetProject(id);
        }

        public List<Project> GetProjectByTitle(string title)
        {
            return _dbProject.GetProjectByTitle(title);
        }

        public bool DeleteProject(int id)
        {
            return _dbProject.RemoveProject(id);
        }

        public bool UpdateProject(int id, string title, string description, string projectFolder)
        {
            if (_dbProject.GetProject(id) != null)
            {
                return _dbProject.UpdateProject(id, title, description, projectFolder);
            }
            return false;
        }

        public bool AddUserToProject(int projectId, User user)
        {
            if (_dbProject.GetProject(projectId) != null && _userController.FindUserById(user.Id) != null)
            {
                return _dbProject.AddUserToProject(projectId, user);
            }
            return false;
        }

        public bool RemoveUserFromProject(int projectId, User user)
        {
            return _dbProject.RemoveUserFromProject(projectId, user);
        }

        public bool AddProjectAdministratorToProject(int projectId, User projectAdministrator)
        {
            return _dbProject.AddProjectAdministratorToProject(projectId, projectAdministrator);
        }

        public bool RemoveProjectAdministratorFromProject(int projectId, User projectAdministrator)
        {
            return _dbProject.RemoveProjectAdministratorFromProject(projectId, projectAdministrator);
        }

        /// <summary>
        /// Returns a list of projects with specified id range, first included last excluded
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <returns>List of Project between the given range</returns>
        public List<Project> GetSomeProjects(int first, int last)
        {
            List<Project> projects = _dbProject.GetAllProjects().Where(x => x.Id >= first && x.Id > last).ToList();
            return projects;
        }

        /// <summary>
        /// Returns a list of Project within the last parameter with last included
        /// </summary>
        /// <param name="last"></param>
        /// <returns>List of project up to Last</returns>
        public List<Project> GetSomeProjects(int last)
        {
            List<Project> projects = _dbProject.GetAllProjects().Where(x => x.Id >= last).ToList();
            return projects;
        }
    }

}