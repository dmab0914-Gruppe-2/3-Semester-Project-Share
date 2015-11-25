using System;
using System.Collections.Generic;
using System.Data.Linq;
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
        public Table<File> Files;
        //public Table<FileVersion> FileVersions;
    }
}
