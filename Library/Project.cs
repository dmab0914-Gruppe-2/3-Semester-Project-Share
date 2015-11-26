using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;

namespace Library
{
    #pragma warning disable 0169    // disable never used warnings for fields that are being used by LINQ
    [Table]
    public class Project
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string Title { get; set; }
        [Column]
        public string Description { get; set; }
        [Column]
        public string ProjectFolder { get; set; }

        /// <summary>
        /// Adds project correlation to User, with ProjectUsers for all project Members.
        /// </summary>
        private EntitySet<ProjectUsers> _projectUsers = new EntitySet<ProjectUsers>();
        [Association(Storage = "_projectUsers", OtherKey = "projectId", ThisKey = "Id")]
        internal ICollection<ProjectUsers> ProjectUsers
        {
            get { return _projectUsers;}
            set { _projectUsers.Assign(value);}
        }
        /// <summary>
        /// Get all user members of the project.
        /// </summary>
        public ICollection<User> ProjectMembers { 
            get { return (from user in ProjectUsers select user.User).ToList(); }
            private set { }
        }
        public List<User> ProjectAdministrators { get; private set; } //TODO DB code
        //[Column]
        private List<File> ProjectFiles { get; set; } //TODO DB code

        public Project()
        {
            
        }

        public Project(string title, string description, string projectFolder, User projectAdministrator)
        {
            Title = title;
            Description = description;
            ProjectFolder = projectFolder;
            //ProjectMembers = ProjectMembers;
            ProjectAdministrators = new List<User> { projectAdministrator };
            ProjectFiles = new List<File>();
        }

        public Project(int id, string title, string description, string projectFolder, User projectAdministrator)
        {
            Id = id;
            Title = title;
            Description = description;
            ProjectFolder = projectFolder;
            //ProjectMembers = ProjectMembers;
            ProjectAdministrators = new List<User> {projectAdministrator};
            ProjectFiles = new List<File>();
        }

        public Project(int id, string title, string description, string projectFolder, List<User> ProjectMembers, List<User> projectAdministrators, List<File> projectFiles)
        {
            Id = id;
            Title = title;
            Description = description;
            ProjectFolder = projectFolder;
            this.ProjectMembers = ProjectMembers;
            ProjectAdministrators = projectAdministrators;
            ProjectFiles = projectFiles;
        }
    }
}
