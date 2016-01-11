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
        const string description = "Its a fairly big project?";
        const string projectFolder = @"c:\";
        private User projectAdminUser;
        private Project project1;
        private Project project2;
        private Project project3;
        private Project project4;
        private Project project5;

        //User projectAdminUser = new User
        //{
        //    Id = 1,
        //    Username = "arm",
        //    Password = "1234",
        //    Email = "test@hansen.dk",
        //    Type = UserType.Administrator
        //};


        ProjectController projectController = new ProjectController();

        #region SetupTest
        [TestInitialize]
        public void Setup()
        {
            UserController userController = new UserController();
            projectAdminUser = userController.FindUsersByUserName("nsw").FirstOrDefault();
            project1 = new Project("World Domination", "Self Explainatory", @"WorldDomination", projectAdminUser);
            project2 = new Project("Bridge Construction", "Bridge over Klisterkanalen", @"BridgeConstruction", projectAdminUser);
            project3 = new Project("Recruiting", "Get more members", @"Recruiters", projectAdminUser);
            project4 = new Project("Server code", "Backend server code", @"Backend", projectAdminUser);
            project5 = new Project("Life and Universe", "What is 42?", @"42", projectAdminUser);
            projectController.AddProject(project1.Title,project1.Description,project1.ProjectFolder,project1.ProjectAdministrators.FirstOrDefault());
            projectController.AddProject(project2.Title, project2.Description, project2.ProjectFolder, project2.ProjectAdministrators.FirstOrDefault());
            projectController.AddProject(project3.Title, project3.Description, project3.ProjectFolder, project3.ProjectAdministrators.FirstOrDefault());
            projectController.AddProject(project4.Title, project4.Description, project4.ProjectFolder, project4.ProjectAdministrators.FirstOrDefault());
            projectController.AddProject(project4.Title, project5.Description, project5.ProjectFolder, project5.ProjectAdministrators.FirstOrDefault());
        }
        #endregion

        #region Test Teardown

        [TestCleanup]
        public void Teardown()
        {
            List<Project> projects = projectController.GetProjectByTitle(project1.Title);
            projectController.GetProjectByTitle(project2.Title).ForEach(delegate(Project project)
            {
                projects.Add(project);
            });
            projectController.GetProjectByTitle(project3.Title).ForEach(delegate(Project project)
            {
                projects.Add(project);
            });
            projectController.GetProjectByTitle(project4.Title).ForEach(delegate(Project project)
            {
                projects.Add(project);
            });
            projectController.GetProjectByTitle(project5.Title).ForEach(delegate(Project project)
            {
                projects.Add(project);
            });
            projectController.GetProjectByTitle(title).ForEach(delegate(Project project)
            {
                projects.Add(project);
            });
            List<bool> results = new List<bool>();
            foreach (Project project in projects)
            {
                bool result = projectController.DeleteProject(project.Id);
                results.Add(result);
            }
            foreach (bool b in results)
            {
                Assert.AreEqual(true, b);
            }
            //foreach (List<Project> projects in projectsList)
            //{
            //    foreach (Project project in projects)
            //    {
            //        projectController.DeleteProject(project.Id);
            //    }
            //}
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
            ProjectReturnType returnValue = projectController.AddProject(project.Title, project.Description, project.ProjectFolder, project.ProjectAdministrators.FirstOrDefault());

            Assert.AreEqual(ProjectReturnType.Success, returnValue);
        }

        [TestMethod]
        public void TestCreateProjectFailTitle2()
        {
            Project project = new Project(id, null, description, projectFolder, projectAdminUser);
            ProjectReturnType returnValue = projectController.AddProject(project.Title, project.Description, project.ProjectFolder, project.ProjectAdministrators.FirstOrDefault());
            Assert.AreEqual(ProjectReturnType.TitleMissing, returnValue);
        }

        [TestMethod]
        public void TestCreateProjectFailDescription2()
        {
            Project project = new Project(id, title, null, projectFolder, projectAdminUser);
            ProjectReturnType returnValue = projectController.AddProject(project.Title, project.Description, project.ProjectFolder, project.ProjectAdministrators.FirstOrDefault());
            Assert.AreEqual(ProjectReturnType.DescriptionMissing, returnValue);
        }

        [TestMethod]
        public void TestCreateProjectFailProjectFolder2()
        {
            Project project = new Project(id, title, description, null, projectAdminUser);
            ProjectReturnType returnValue = projectController.AddProject(project.Title, project.Description, project.ProjectFolder, project.ProjectAdministrators.FirstOrDefault());
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
            Assert.AreEqual(@"WorldDomination", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId2()
        {
            List<Project> projects = projectController.GetProjectByTitle("Bridge Construction");
            Project project = projects.FirstOrDefault();
            //Assert.AreEqual(1, project.Id);
            Assert.AreEqual("Bridge Construction", project.Title);
            Assert.AreEqual("Bridge over Klisterkanalen", project.Description);
            Assert.AreEqual(@"BridgeConstruction", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId3()
        {
            List<Project> projects = projectController.GetProjectByTitle("Recruiting");
            Project project = projects.FirstOrDefault();
            Assert.AreEqual("Recruiting", project.Title);
            Assert.AreEqual("Get more members", project.Description);
            Assert.AreEqual(@"Recruiters", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId4()
        {
            List<Project> projects = projectController.GetProjectByTitle("World Domination");
            Project project = projects.FirstOrDefault();
            Assert.AreEqual("World Domination", project.Title);
            Assert.AreEqual("Self Explainatory", project.Description);
            Assert.AreEqual(@"WorldDomination", project.ProjectFolder);
        }
        [TestMethod]
        public void TestGetProjectId5()
        {
            List<Project> projects = projectController.GetProjectByTitle("World Domination");
            Project project = projects.FirstOrDefault();
            Assert.AreEqual("World Domination", project.Title);
            Assert.AreEqual("Self Explainatory", project.Description);
            Assert.AreEqual(@"WorldDomination", project.ProjectFolder);
        }

        #endregion

        #region Updateproject



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

            bool success = projectController.AddUserToProject(project.Id, user);
            Assert.AreEqual(true, success);

            success = projectController.AddProjectAdministratorToProject(project.Id, user);
            Assert.AreEqual(true, success);

            success = projectController.RemoveProjectAdministratorFromProject(project.Id, user);
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
        #region DeleteProjects

        [TestMethod]
        public void TestRemoveProject()
        {
            List<Project> projects = projectController.GetProjectByTitle(project1.Title);

            bool result = projectController.DeleteProject(projects.FirstOrDefault().Id);
            Assert.AreEqual(true, result);

        }

        #endregion
    }
}
