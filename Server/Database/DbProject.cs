using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.Transactions;

namespace Server.Database
{
    public class DbProject : IDbProject
    {
        private DbContext dbContext;
        private DbFile dbFile;
        private DbUser dbUser;
        public DbProject()
        {
            dbContext = new DbContext();
            dbFile = new DbFile();
            dbUser = new DbUser();
        }

        public bool AddProject(string title, string description, string projectFolder, Library.User projectAdministratorUser)
        {
            User adminUser = dbUser.FindUserById(projectAdministratorUser.Id);
            if (adminUser == null)
            {
                return false;
            }

            Project project = new Project(title, description, projectFolder, adminUser);
            try
            {
                var option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    dbContext.Projects.InsertOnSubmit(project);
                    dbContext.ProjectUsers.InsertOnSubmit(new ProjectUsers { Project = project, User = project.ProjectAdministrators.FirstOrDefault(), UserType = UserType.Administrator });
                    dbContext.SubmitChanges();
                    if (true) //TODO check if the data added to db were sucessfull / valid.
                        scope.Complete();
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Project not added to db " + e);
            }
        }

        public bool RemoveProject(int projectId)
        {
            //throw new NotImplementedException();
            Project project = GetProject(projectId);
            if (project != null)
            {
                bool error = false;
                try
                {
                    var option = new TransactionOptions();
                    option.IsolationLevel = IsolationLevel.ReadCommitted;

                    using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, option))
                    {
                        project = GetProject(projectId);
                        List<bool> success = new List<bool>();
                        foreach (User user in project.ProjectAdministrators)
                        {
                            success.Add(RemovePersonFromProject(project, user));
                        }
                        foreach (User user in project.ProjectMembers)
                        {
                            success.Add(RemovePersonFromProject(project, user));
                        }
                        foreach (File file in dbFile.GetAllFilesForProject(project.Id))
                        {
                            success.Add(dbFile.RemoveFile(file));
                        }
                        //bool f = dbFile.RemoveAllFilesFromProject(projectId);
                        dbContext.Projects.DeleteOnSubmit(project);
                        if (success.TrueForAll(x => x.Equals(true))) //Checks if all values in the List matches true, and returns true if so.
                        {
                            dbContext.SubmitChanges();
                            scope.Complete();
                        }
                        else
                        {
                            scope.Dispose();
                            error = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Project could not be removed. Project id: " + projectId + "Error: \n" + e);
                    return false;
                }
                if (error != true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Get a single project from the given id, with all data filled.
        /// </summary>
        /// <param name="projectId">the project id of the project to retrieve</param>
        /// <returns>The project with the given id if found, null if not.</returns>
        public Project GetProject(int projectId)
        {
            try
            {
                Project project = dbContext.Projects.FirstOrDefault(i => i.Id == projectId);
                if (project != null)
                {
                    project.ProjectMembers = GetProjectMembers(projectId);
                    project.ProjectFiles = dbFile.GetAllFilesForProject(project.Id);
                    project.ProjectAdministrators = GetProjectAdministrators(project.Id);
                    return project;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong, when looking for the given Project id: " + projectId + " Error Message: \n" + e);
            }
            return null;
        }

        public bool UpdateProject(int id, string title, string description, string projectFolder)
        {
            Project project = GetProject(id);
            project.Title = title;
            project.Description = description;
            project.ProjectFolder = projectFolder;
            try
            {
                dbContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong, when updating the data in project id: " + id + " Error Message: \n" + e);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Get all Projects from database. ProjectFiles, ProjectAdministrators will be empty as you might not need it atm.
        /// Request the given project with GetProject(int id) to get the rest.
        /// </summary>
        /// <returns>A list of Projects from the databse with limited data.</returns>
        public List<Project> GetAllProjects()
        {
            return dbContext.Projects.ToList();
        }

        public List<Project> GetProjectByTitle(string title)
        {
            var projects = from project in dbContext.Projects
                           where project.Title.Equals(title)
                           select project;
            foreach (Project project in projects)
            {
                project = GetProject(project.Id);
            }
            return projects.ToList();
        }

        public bool AddUserToProject(int projectId, User user)
        {
            User nUser = dbUser.FindUserById(user.Id);
            if (nUser == null)
            {
                return false;
            }
            return AddUserToProject(projectId, nUser, UserType.User);
        }

        /// <summary>
        /// Removes the given user from the given project, if the user is member of the project.
        /// </summary>
        /// <param name="projectId">The project to remove the user from.</param>
        /// <param name="user">THe user to be removed from the project.</param>
        /// <returns>True if the user exsisted and if the action succeeded. False if either failed.</returns>
        public bool RemoveUserFromProject(int projectId, User user)
        {
            Project project = GetProject(projectId);
            User nUser = dbUser.FindUserById(user.Id);
            if (project == null)
            {
                return false;
            }
            else if (project.ProjectMembers.FirstOrDefault(x => x.Id == nUser.Id) != null)
            {

                return RemovePersonFromProject(project, nUser);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Adds a given user to the given project as Administrative project user.
        /// </summary>
        /// <param name="projectId">The project for the user to become administrator of.</param>
        /// <param name="projectAdministrator">The user to become project administrator.</param>
        /// <returns>True if the action succeeded, and false if not.</returns>
        public bool AddProjectAdministratorToProject(int projectId, User projectAdministrator)
        {
            bool error = false;
            User nAdmin = dbUser.FindUserById(projectAdministrator.Id);
            try
            {
                var option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    bool r = RemoveUserFromProject(projectId, nAdmin);
                    bool a = AddUserToProject(projectId, nAdmin, UserType.Administrator);
                    if (r == true && a == true)
                    {
                        scope.Complete();
                    }
                    else
                    {
                        scope.Dispose();
                        error = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Project Administrator not added to project " + e);
                return false;
            }
            if (error)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Removes the given project administrator from the given project. And adds them as normal Users.
        /// </summary>
        /// <param name="projectId">The project to remove the administrator from.</param>
        /// <param name="projectAdministrator">The Administrator to remove.</param>
        /// <returns>True if the action succeeded, and false if not.</returns>
        public bool RemoveProjectAdministratorFromProject(int projectId, User projectAdministrator)
        {
            bool error = false;
            Project project = GetProject(projectId);
            User nAdmin = dbUser.FindUserById(projectAdministrator.Id);
            if (project == null || nAdmin == null)
            {
                return false;
            }
            else if (project.ProjectAdministrators.FirstOrDefault(x => x.Id == nAdmin.Id) != null)
            {
                try
                {
                    var option = new TransactionOptions();
                    option.IsolationLevel = IsolationLevel.ReadCommitted;

                    using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, option))
                    {
                        bool r = RemovePersonFromProject(project, nAdmin); //Removes the administrator so the person can be added as a normal user instead
                        bool a = AddUserToProject(projectId, nAdmin); //Adds the same user again bus as a normal user instead.
                        if (r == true && a == true)
                        {
                            scope.Complete();
                        }
                        else
                        {
                            scope.Dispose();
                            error = true;
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Project Administrator id: " + projectAdministrator.Id + " not removed from project /n" + e);
                    error = true;
                }

            }
            else
            {
                error = true;
            }

            if (error)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<User> GetProjectAdministrators(int projectId) //TODO test db code.
        {
            var users = from user in dbContext.ProjectUsers
                        where user.Project.Id.Equals(projectId) && user.UserType.Equals(UserType.Administrator)
                        select user.User;
            return users.ToList();
        }

        private List<User> GetProjectMembers(int projectId) //TODO test db code.
        {
            var users = from user in dbContext.ProjectUsers
                        where user.Project.Id.Equals(projectId) && user.UserType.Equals(UserType.User)
                        select user.User;
            return users.ToList();
        }

        private bool AddUserToProject(int projectId, User user, UserType type)
        {
            Project project = GetProject(projectId);
            if (project == null || user == null)
            {
                return false;
            }
            try
            {
                //dbContext.ProjectUsers.InsertOnSubmit(new ProjectUsers { Project = project, User = user, UserType = type });
                string sql = "INSERT INTO ProjectUsers VALUES (" + project.Id + "," + user.Id + "," + EnumToint(type) + ")";
                dbContext.ExecuteCommand(sql);
                dbContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong, when adding the user to the project id: " + projectId + " Error Message: \n" + e);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Removes the individual person in the given Project.
        /// There's no check whether the user or project exists or not.
        /// So checks should be made prior to executing this method.
        /// </summary>
        /// <param name="project">The project to remove the user from</param>
        /// <param name="user">THe user to be removed from the given project</param>
        /// <returns></returns>
        private bool RemovePersonFromProject(Project project, User user)
        {
            var t = from d in dbContext.ProjectUsers
                    where project.Equals(d.Project) && user.Equals(d.User)
                    select d;
            dbContext.ProjectUsers.DeleteOnSubmit(t.ToList().FirstOrDefault());
            try
            {
                dbContext.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong, when deleting the user id: " + user.Id + ", from the project id: " + project.Id + " Error Message: \n" + e);
                return false;
            }
        }

        private int EnumToint(UserType type)
        {
            if (type.Equals(UserType.Guest))
            {
                return 1;
            }
            else if (type.Equals(UserType.User))
            {
                return 2;
            }
            else if (type.Equals(UserType.Administrator))
            {
                return 3;
            }
            return 0;
        }
    }
}
