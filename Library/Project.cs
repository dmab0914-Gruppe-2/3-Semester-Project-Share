using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
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
        [Column]
        private List<User> ProjectMembers { get; set; }
        [Column]
        private List<User> ProjectAdministrators { get; set; }
        [Column]
        private List<File> ProjectFiles { get; set; }

        public Project()
        {
            
        }

        public Project(string title, string description, string projectFolder, User projectAdministrator)
        {
            Title = title;
            Description = description;
            ProjectFolder = projectFolder;
            ProjectMembers = ProjectMembers;
            ProjectAdministrators = new List<User> { projectAdministrator };
            ProjectFiles = new List<File>();
        }

        public Project(int id, string title, string description, string projectFolder, User projectAdministrator)
        {
            Id = id;
            Title = title;
            Description = description;
            ProjectFolder = projectFolder;
            ProjectMembers = ProjectMembers;
            ProjectAdministrators = new List<User> {projectAdministrator};
            ProjectFiles = new List<File>();
        }

        public Project(int id, string title, string description, string projectFolder, /*List<User> ProjectMembers,*/ List<User> projectAdministrators, List<File> projectFiles)
        {
            Id = id;
            Title = title;
            Description = description;
            ProjectFolder = projectFolder;
            //ProjectMembers = ProjectMembers;
            ProjectAdministrators = projectAdministrators;
            ProjectFiles = projectFiles;
        }
    }
}
