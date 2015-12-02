using System;
using System.Collections.Generic;
using System.Linq;
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
            Email = "test@hansen.dk",
            Type = UserType.Administrator
        };

        static User[] users =
        {
            new User("arm", "1234", "gud@gudenet.dk", UserType.Administrator), 
            new User("nsw", "5678", "nsfw@ucn.dk", UserType.Administrator), 
            new User("nmi", "1234", "nmi@jacobsjov.dk", UserType.User), 
            new User("rok", "5678", "ronnie@failed.org", UserType.Guest)
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
            //Project project = projectController.GetProject(1);
            List<Project> projects = projectController.GetProjectByTitle("World Domination");
            Project project = projects.FirstOrDefault();
            //Assert.AreEqual(1, project.Id);
            Assert.AreEqual("World Domination", project.Title);
            Assert.AreEqual("Self Explainatory", project.Description);
            Assert.AreEqual(@"c:\", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId2()
        {
            List<Project> projects = projectController.GetProjectByTitle("Bridge Construction");
            Project project = projects.FirstOrDefault();
            //Assert.AreEqual(1, project.Id);
            Assert.AreEqual("Bridge Construction", project.Title);
            Assert.AreEqual("Bridge over Klisterkanalen", project.Description);
            Assert.AreEqual(@"C:\Projects\BridgeConstruction", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId3()
        {
            List<Project> projects = projectController.GetProjectByTitle("Recruiting");
            Project project = projects.FirstOrDefault();
            Assert.AreEqual("Recruiting", project.Title);
            Assert.AreEqual("Get more members", project.Description);
            Assert.AreEqual(@"C:\Projects\Recruiters", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId4()
        {
            List<Project> projects = projectController.GetProjectByTitle("World Domination");
            Project project = projects.FirstOrDefault();
            Assert.AreEqual("World Domination", project.Title);
            Assert.AreEqual("Self Explainatory", project.Description);
            Assert.AreEqual(@"c:\", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId5()
        {
            List<Project> projects = projectController.GetProjectByTitle("World Domination");
            Project project = projects.FirstOrDefault();
            Assert.AreEqual("World Domination", project.Title);
            Assert.AreEqual("Self Explainatory", project.Description);
            Assert.AreEqual(@"c:\", project.ProjectFolder);
        }

#endregion

#region Updateproject



#endregion


#region DeleteProjects

#endregion

#region Add and Remove Project user

        [TestMethod]
        public void TestAddRemoveProjectUserSuccess()
        {
            UserController userController = new UserController();
            List<User> users = userController.FindUsersByUserName("arm");
            User user = users.FirstOrDefault();

            //Test if it's the correct user!
            Assert.AreEqual(user.Email, "gud@gudenet.dk");
            Assert.AreEqual(user.Type, UserType.Administrator);

            List<Project> projects = projectController.GetProjectByTitle("World Domination");
            Project project = projects.FirstOrDefault();
            int projectId = project.Id;

            bool success = projectController.AddUserToProject(projectId, user);
            Assert.AreEqual(true, success);

            success = projectController.RemoveUserFromProject(projectId, user);
            Assert.AreEqual(true, success);

        }

        [TestMethod]
        public void TestAddRemoveProjectUserFail()
        {
            UserController userController = new UserController();
            List<User> users = userController.FindUsersByUserName("arm");
            User user = users.FirstOrDefault();

            //Test if it's the correct user!
            Assert.AreEqual(user.Email, "gud@gudenet.dk");
            Assert.AreEqual(user.Type, UserType.Administrator);

            int projectId = -1;

            bool success = projectController.AddUserToProject(projectId, user);
            Assert.AreEqual(false, success);

            success = projectController.RemoveUserFromProject(projectId, user);
            Assert.AreEqual(false, success);

        }


#endregion

#region Add and Remove Project Administrator

        [TestMethod]
        public void TestAddRemoveProjectAdminSuccess()
        {
            UserController userController = new UserController();
            List<User> users = userController.FindUsersByUserName("arm");
            User user = users.FirstOrDefault();

            //Test if it's the correct user
            Assert.AreEqual(user.Email, "gud@gudenet.dk");
            Assert.AreEqual(user.Type, UserType.Administrator);

            List<Project> projects = projectController.GetProjectByTitle("World Domination");
            Project project = projects.FirstOrDefault();
            int projectId = project.Id;

            bool success = projectController.AddProjectAdministratorToProject(projectId, user);
            Assert.AreEqual(true, success);

            success = projectController.RemoveProjectAdministratorFromProject(projectId, user);
            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void TestAddRemoveProjectAdminFail()
        {
            UserController userController = new UserController();
            List<User> users = userController.FindUsersByUserName("arm");
            User user = users.FirstOrDefault();

            //Test if it's the correct user
            Assert.AreEqual(user.Email, "gud@gudenet.dk");
            Assert.AreEqual(user.Type, UserType.Administrator);

            int projectId = -1;

            bool success = projectController.AddProjectAdministratorToProject(projectId, user);
            Assert.AreEqual(false, success);

            success = projectController.RemoveProjectAdministratorFromProject(projectId, user);
            Assert.AreEqual(false, success);
        }

#endregion

    }
}
