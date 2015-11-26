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
        //Second method with project as input parameter
        [TestMethod]
        public void TestCreateProjectSuccess2()
        {
            Project project = new Project(id, title, description, projectFolder, projectAdminUser);
            ProjectReturnType returnValue = projectController.AddProject(project);

            Assert.AreEqual(ProjectReturnType.Success, returnValue);
        }

        [TestMethod]
        public void TestCreateProjectFailTitle2()
        {
            Project project = new Project(id, null, description, projectFolder, projectAdminUser);
            ProjectReturnType returnValue = projectController.AddProject(project);
            Assert.AreEqual(ProjectReturnType.TitleMissing, returnValue);
        }

        [TestMethod]
        public void TestCreateProjectFailDescription2()
        {
            Project project = new Project(id, title, null, projectFolder, projectAdminUser);
            ProjectReturnType returnValue = projectController.AddProject(project);
            Assert.AreEqual(ProjectReturnType.DescriptionMissing, returnValue);
        }

        [TestMethod]
        public void TestCreateProjectFailProjectFolder2()
        {
            Project project = new Project(id, title, description, null, projectAdminUser);
            ProjectReturnType returnValue = projectController.AddProject(project);
            Assert.AreEqual(ProjectReturnType.ProjectFolderMissing, returnValue);
        }

        //[TestMethod]
        //public void TestCreateProjectFailUser2()
        //{
        //    Project project = new Project(id, title, description, projectFolder, null);
        //    ProjectReturnType returnValue = projectController.AddProject(project);
        //    Assert.AreEqual(ProjectReturnType.ProjectAdministratorUserMissing, returnValue);
        //}
#endregion


#region GetAllProjects
        [TestMethod]
        public void TestGetAllProjects()
        {
            List<Project> projects = projectController.GetAllProjects();
            Assert.IsNotNull(projects);
        }
#endregion


#region GetProject

        [TestMethod]
        public void TestGetProjectId1()
        {
            Project project = projectController.GetProject(1);
            Assert.Equals(1, project.Id);
            Assert.Equals("World Domination", project.Title);
            Assert.Equals("Self Explainatory", project.Description);
            Assert.Equals(@"c:\", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId2()
        {
            Project project = projectController.GetProject(1);
            Assert.Equals(2, project.Id);
            Assert.Equals("Bridge Construction", project.Title);
            Assert.Equals("Bridge over Klisterkanalen", project.Description);
            Assert.Equals(@"C:\Projects\BridgeConstruction", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId3()
        {
            Project project = projectController.GetProject(1);
            Assert.Equals(3, project.Id);
            Assert.Equals("Recruiting", project.Title);
            Assert.Equals("Get more members", project.Description);
            Assert.Equals(@"C:\Projects\Recruiters", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId4()
        {
            Project project = projectController.GetProject(1);
            Assert.Equals(4, project.Id);
            Assert.Equals("World Domination", project.Title);
            Assert.Equals("Self Explainatory", project.Description);
            Assert.Equals(@"c:\", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId5()
        {
            Project project = projectController.GetProject(1);
            Assert.Equals(5, project.Id);
            Assert.Equals("World Domination", project.Title);
            Assert.Equals("Self Explainatory", project.Description);
            Assert.Equals(@"c:\", project.ProjectFolder);
        }

#endregion

#region Updateproject



#endregion


#region DeleteProjects

#endregion
    }
}
