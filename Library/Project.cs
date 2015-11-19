using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProjectFolder { get; set; }
        private List<User> ProjectMembers { get; set; }
        private List<User> ProjectAdministrators { get; set; }
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
