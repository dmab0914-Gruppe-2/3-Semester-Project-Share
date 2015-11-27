using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Database
{
    class DbFile : IDbFile
    {
        static File[] filearr = { new File { Id = 1, Title = "testFIl", Description = "awesome file", VersionNr = 1, },
                                  new File { Id = 2, Title = "doc", Description = "document file", VersionNr = 1, },
                                  new File { Id = 3, Title = "oversigt", Description = "projekt oversigt", VersionNr = 1, },
                                  new File { Id = 4, Title = "Rapport", Description = "projekt rapport", VersionNr = 1, }
                                  };

        private List<File> filesTest;
        private DbContext dbContext;
        public DbFile()
        {
            dbContext = new DbContext();
            filesTest = new List<File>(filearr);
        }
        
        public List<File> GetAllFilesForProject(int projectId)
        {
            var files = from file in dbContext.Files
                        from projectfiles in dbContext.ProjectFiles
                        where (file.Id == projectfiles.File.Id) && (projectfiles.Project.Id == projectId)
                        select file;
             return files.ToList();
        }

        public File GetFile(int fileId)
        {
            var item = dbContext.Files.First(i => i.Id == fileId);
            if (item != null)
            {
                return item;
            }
            return null;
        }

        public bool AddFIle(File file)
        {
            //dbContext.ExecuteCommand() //TODO Lock db pre write.
            dbContext.Files.InsertOnSubmit(file);
            dbContext.SubmitChanges();
            return true;
        }
    }
}
