﻿using System;
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
        private readonly IDbUser _dbUser = new DbUser();

        public ProjectController()
        {

        }

        public ProjectReturnType AddProject(string title, string description, string projectFolder,
            User projectAdministratorUser)
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
            _dbProject.AddProject(project.Title, project.Description, project.ProjectFolder,
                project.ProjectAdministrators.FirstOrDefault());
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
            return _dbProject.UpdateProject(id, title, description, projectFolder);
        }

        public bool AddUserToProject(int projectId, User user)
        {
            if (_dbProject.GetProject(projectId) != null && _dbUser.FindUserById(user.Id) != null)
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