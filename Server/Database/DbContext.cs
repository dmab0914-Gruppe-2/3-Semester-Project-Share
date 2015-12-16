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
#pragma warning disable 0169    // disable never used warnings for fields that are being used by LINQ
    sealed class DbContext : DataContext
    {
        private static DbContext instance = null;
        private static readonly object threadlock = new Object();
        private DbContext()
            : base(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ProjectShare;Integrated Security=True")
            //: base("Data Source=kraka.ucn.dk;Initial Catalog=dmab0914_2Sem_2;User ID=dmab0914_2Sem_2;Password=IsAllowed")
        //TODO Replace this is you're getting errors
        {

        }

        public static DbContext Instance
        {
            get
            {
                lock (threadlock)
                {
                    if (instance == null)
                    {
                        instance = new DbContext();
                    }
                    return instance;
                }
            }
        }


        public Table<User> Users;
        public Table<File> Files;
        public Table<FileVersion> FileVersions;
        public Table<Project> Projects;
        public Table<ProjectUsers> ProjectUsers;
        public Table<ProjectFiles> ProjectFiles;
        public Table<ChatMessage> ChatMessages;
        public Table<FileChat> FileChats;

        //public Table<UserType> UserTypes;
        //public Table<UserChat> UserChats;
        //public Table<ProjectChat> ProjectChats;
    }

    //[Table(Name = ProjectUsers)]
    //class ProjectUser
    //{

    //}
}
