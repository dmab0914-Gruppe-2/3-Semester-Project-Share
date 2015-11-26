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

        public int UpdateProject(int id, string title, string description, string projectFolder, List<Library.User> ProjectMembers, List<Library.User> projectAdministrators)
        {
            throw new NotImplementedException();
        }

        public int DeleteProject(int id)
        {
            return projectController.DeleteProject(id);
        }
    }
}
