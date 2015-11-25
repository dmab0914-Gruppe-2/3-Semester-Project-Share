using System;
using System.Diagnostics;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class AddFileToProject21Test
    {
<<<<<<< HEAD
        [TestMethod]
        public void GetProject()
        {
            const int id = 1;

            ProjectController projectController = new ProjectController();
            Project project = projectController.GetProject(id);
            Assert.IsNotNull(project);
        }

        [TestMethod]
        public void UploadFileToProject()
        {
            int projectId = 1;
            string title = "Fiske filen";
            string description = "Generelt bare meget om fisk..";

            ProjectController projectController = new ProjectController();
            Project project = projectController.GetProject(projectId);
            
            projectController.addFileToProject(projectId, file); //Will throw exception if file already exists.
            string filePath = "/" + projectId + "/";
            //System.IO.File actualFile = null;
            //TODO This will have to be changed, as we have currently no idea how sending files from client to server would work..

            File file = new File(title, description);
            projectController.addFileToProject(projectId, file, actualFile); //TODO This ain't going to work..
        }
=======
        //[TestMethod]
        //public void FindProject()
        //{
        //    const int id = 1;
        //    const string title = "The Big Project";
        //    const string description = "It's a fairly big project?";
        //    const string projectFolder = "theBigproject";
        //    const string userName = "FedeFrank";
        //    const string password = "1234";
        //    const UserType type = UserType.User;

        //    User projectAdministrator = new User(userName, password, type);
        //    ProjectController projectController = new ProjectController();
        //    projectController.addProject(new Project(id, title, description, projectFolder, projectAdministrator));
        //    Project project = projectController.FindProject(id);

        //    Assert.AreEqual(title, project.Title);
        //    Assert.AreEqual(description, project.Description);
        //    Assert.AreEqual(projectFolder, project.ProjectFolder);
        //}

        //[TestMethod]
        //public void UploadFileToProject()
        //{
        //    string title = "Fiske filen";
        //    string description = "Generelt bare meget om fisk..";
        //    System.IO.File actualFile = null;
        //    //TODO This will have to be changed, as we have currently no idea how sending files from client to server would work..

        //    File file = new File(title, description);
        //    ProjectController projectController = new ProjectController();
        //    projectController.addFileToProject(projectId, file, actualFile); //TODO This ain't going to work..
        //}
>>>>>>> refs/remotes/origin/master
    }
}
