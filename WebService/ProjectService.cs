using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server;

namespace WebService
{

    public class ProjectService : IProjectService
    {
        ProjectController projectController = new ProjectController();

        public Library.ProjectReturnType AddProject(string title, string description, string projectFolder, Library.User projectAdministratorUser)
        {
            return projectController.AddProject(title, description, projectFolder, projectAdministratorUser);
        }


        public List<Library.Project> GetAllProjects()
        {
            return projectController.GetAllProjects();
        }


        public Library.Project GetProject(int id)
        {
            return projectController.GetProject(id);
        }

        public bool UpdateProject(int id, string title, string description, string projectFolder)
        {
            return projectController.UpdateProject(id, title, description, projectFolder);
        }

        public bool DeleteProject(int id)
        {
            return projectController.DeleteProject(id);
        }


        public bool AddUserToProject(int projectId, Library.User user)
        {
            return projectController.AddUserToProject(projectId, user);
        }

        public bool RemoveUserFromProject(int projectId, Library.User user)
        {
            return projectController.RemoveUserFromProject(projectId, user);
        }

        public bool AddProjectAdministratorToProject(int projectId, Library.User projectAdministrator)
        {
            return projectController.AddProjectAdministratorToProject(projectId, projectAdministrator);
        }

        public bool RemoveProjectAdministratorFromProject(int projectId, Library.User projectAdministrator)
        {
            return projectController.RemoveProjectAdministratorFromProject(projectId, projectAdministrator);
        }


        public List<Library.Project> GetProjectByTitle(string title)
        {
            return projectController.GetProjectByTitle(title);
        }

        public List<Library.Project> GetSomeProjectsBetweenId(int first, int last)
        {
            return projectController.GetSomeProjects(first, last);
        }

        public List<Library.Project> GetSomeProjectsToId(int last)
        {
            return projectController.GetSomeProjects(last);
        }
    }
}
