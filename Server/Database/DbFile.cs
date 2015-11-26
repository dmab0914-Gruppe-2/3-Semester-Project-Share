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
        DbContext dbContext = new DbContext();
        static File[] filearr = { new File { Id = 1, Title = "testFIl", Description = "awesome file", VersionNr = 1, },
                                  new File { Id = 2, Title = "doc", Description = "document file", VersionNr = 1, },
                                  new File { Id = 3, Title = "oversigt", Description = "projekt oversigt", VersionNr = 1, },
                                  new File { Id = 4, Title = "Rapport", Description = "projekt rapport", VersionNr = 1, }
                                  };

        List<File> filesTest = new List<File>(filearr);
        public List<File> GetAllFilesForProject(int projectId)
        {
            //var res = from f in dbContext.Files
            //          join fv in dbContext.FileVersions on f.Id equals fv.FileId
            //          join pf in dbContext.ProjectFiles on f.Id equals pf.fileId
            //          where pf.projectId = projectId
            //          select new List<File> { Title = f.Title, Description = f.Description };

            //var files = dbContext.Files.Join(dbContext.FileVersions,
            //                                  file => file.Id,
            //                                  fileversion => fileversion.FileId,
            //                                  (file, fileversion) => file);

            var files = from file in dbContext.Files
                        from projectfiles in dbContext.ProjectFiles


                        where (file.Id == projectfiles.File.Id) && (projectfiles.Project.Id == projectId)
                        select file;
          //  var fesf = dbContext.ProjectFiles.All(i => i.)

            //var filesforProject = dbContext.Files.Join(File, file => file.Id, Fil);


         //   var item = dbContext.Files.All(i => i.Id == projectId);
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
