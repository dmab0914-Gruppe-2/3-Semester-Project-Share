﻿using Library;
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

        List<File> files = new List<File>(filearr);
        public List<File> GetAllFilesForProject(int projectId)
        {
            return files;
        }

        public File GetFile(int fileId)
        {
            DbContext dbContext = new DbContext();
            var item = dbContext.Files.First(i => i.Id == fileId);
            if (item != null)
            {
                return item;
            }
            return null;
        }

        public bool AddFIle(File file)
        {
            DbContext dbContext = new DbContext();
            //dbContext.ExecuteCommand() //TODO Lock db pre write.
            dbContext.Files.InsertOnSubmit(file);
            dbContext.SubmitChanges();
            throw new NotImplementedException();
        }
    }
}
