using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Server.Database
{
    class DbContext : DataContext
    {
        public DbContext() : base("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectShare;Integrated Security=True")
            //TODO Replace this is you're getting errors
        {
            
        }


        public Table<User> Users;
        //public Table<UserType> UserTypes;
        public Table<File> Files;
        public Table<FileVersion> FileVersions;
        public Table<Project> Projects;
        public Table<ProjectUsers> ProjectUsers;
        //public Table<ChatMessage> ChatMessages;
        //public Table<UserChat> UserChats;
        //public Table<FileChat> FileChats;
        //public Table<ProjectChat> ProjectChats;
    }

    //[Table(Name = ProjectUsers)]
    //class ProjectUser
    //{
        
    //}
}
