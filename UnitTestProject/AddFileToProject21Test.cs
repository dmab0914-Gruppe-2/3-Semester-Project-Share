using System;
using System.Diagnostics;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class AddFileToProject21Test
    {
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
    }
}
