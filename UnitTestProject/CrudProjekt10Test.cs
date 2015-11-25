using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using Server;

namespace UnitTestProject
{
    [TestClass]
    public class CrudProjekt10Test
    {
        const int id = 1;
        const string title = "The Big Project";
        const string description = "It's a fairly big project?";
        const string projectFolder = @"c:\";
        User projectAdminUser = new User
        {
            Id = 1,
            Username = "arm",
            Password = "1234",
            Type = UserType.Administrator
        };

        ProjectController projectController = new ProjectController();

#region SetupTest
        [TestInitialize]
        public void Setup()
        {
            Project project1 = new Project(1, "World Domination", "Self Explainatory", @"c:\", projectAdminUser);
            Project project2 = new Project(2, "Bridge Construction", "Bridge over Klisterkanalen", @"C:\Projects\BridgeConstruction", projectAdminUser);
            Project project3 = new Project(3, "Recruiting", "Get more members", @"C:\Projects\Recruiters", projectAdminUser);
            Project project4 = new Project(4, "Server code", "Backend server code", @"C:\Projects\Backend", projectAdminUser);
            Project project5 = new Project(5, "Life and Universe", "What is 42?", @"C:\Projects\42", projectAdminUser);
            projectController.AddProject(project1);
            projectController.AddProject(project2);
            projectController.AddProject(project3);
            projectController.AddProject(project4);
            projectController.AddProject(project5);

        }
#endregion


#region CreateProject
        [TestMethod]
        public void TestCreateProjectSuccess()
        {

            ProjectReturnType returnValue = projectController.AddProject(title, description, projectFolder, projectAdminUser);
            Assert.AreEqual(ProjectReturnType.Success, returnValue);
        }

        [TestMethod]
        public void TestCreateProjectFailTitle()
        {

            ProjectReturnType returnValue = projectController.AddProject(null, description, projectFolder, projectAdminUser);
            Assert.AreEqual(ProjectReturnType.TitleMissing, returnValue); 
        }

        [TestMethod]
        public void TestCreateProjectFailDescription()
        {
            ProjectReturnType returnValue = projectController.AddProject(title, null, projectFolder, projectAdminUser);
            Assert.AreEqual(ProjectReturnType.DescriptionMissing, returnValue);
        }

        [TestMethod]
        public void TestCreateProjectFailProjectFolder()
        {
            ProjectReturnType returnValue = projectController.AddProject(title, description, null, projectAdminUser);
            Assert.AreEqual(ProjectReturnType.ProjectFolderMissing, returnValue);
        }

        [TestMethod]
        public void TestCreateProjectFailUser()
        {
            ProjectReturnType returnValue = projectController.AddProject(title, description, projectFolder, null);
            Assert.AreEqual(ProjectReturnType.ProjectAdministratorUserMissing, returnValue);
        }
#endregion


#region GetAllProjects
        [TestMethod]
        public void TestGetAllProjects()
        {
            List<Project> projects = projectController.GetAllProjects();
            Assert.IsNotNull(projects);
        }
#endregion


    }
}
