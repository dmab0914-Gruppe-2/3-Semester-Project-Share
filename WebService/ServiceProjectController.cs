using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server;

namespace WebService
{

    public class ServiceProjectController : IServiceProjectController
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
    }
}
