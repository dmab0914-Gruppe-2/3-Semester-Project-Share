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
        public DbProject()
        {
            dbContext = new DbContext();
            dbFile = new DbFile();
        }

        public bool AddProject(string title, string description, string projectFolder, Library.User projectAdministratorUser)
        {
            Project project = new Project(title, description, projectFolder, projectAdministratorUser);
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
                throw new Exception("File not added to DB " + e);
            }
        }

        public bool RemoveProject(int id)
        {
            Project project = GetProject(id);
            if (project != null)
            {
                try
                {
                    dbContext.Projects.DeleteOnSubmit(project);
                    dbContext.SubmitChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get a single project from the given id, with all data filled.
        /// </summary>
        /// <param name="id">the project id of the project to retrieve</param>
        /// <returns>The project with the given id if found, null if not.</returns>
        public Project GetProject(int id)
        {
            Project project = dbContext.Projects.First(i => i.Id == id);
            if (project != null)
            {
                project.ProjectFiles = dbFile.GetAllFilesForProject(project.Id);
                project.ProjectAdministrators = GetProjectAdministrators(project.Id);
                return project;
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
            catch(Exception e)
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

        private List<User> GetProjectAdministrators(int id) //TODO test db code.
        {
            var users = from user in dbContext.ProjectUsers
                        where user.Project.Id.Equals(id) && user.UserType.Equals(UserType.Administrator)
                        select user.User;
            return users.ToList();
        }

        public bool AddUserToProject(int projectId, User user)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUserFromProject(int projectId, User user)
        {
            throw new NotImplementedException();
        }

        public bool AddProjectAdministratorToProject(int projectId, User projectAdministrator)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProjectAdministratorFromProject(int projectId, User projectAdministrator)
        {
            throw new NotImplementedException();
        }
        
        public Project[] GetProjectByTitle(string title)
        {
            var projects = from project in dbContext.Projects
                where project.Title.Equals(title)
                select project;
            return projects.ToArray();
        }
    }
}
