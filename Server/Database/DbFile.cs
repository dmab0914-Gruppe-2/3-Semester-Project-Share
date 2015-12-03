using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
                        where (file.Project == projectId)
                        select file;
            if (files != null)
            {
                return files.ToList();
            }
            return null;
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
            try
            {
                //dbContext.ExecuteCommand() //TODO Lock db pre write.
                dbContext.Files.InsertOnSubmit(file);
                dbContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool RemoveFile(File file)
        {
            File nFile = GetFile(file.Id);
            if (nFile != null)
            {
                IDbFileVersion dbFileVersion = new DbFileVersion();
                bool error = false;
                try
                {
                    var option = new TransactionOptions();
                    option.IsolationLevel = IsolationLevel.ReadCommitted;

                    using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, option))
                    {
                        nFile = GetFile(file.Id);
                        //Delete all file versions related to file
                        bool fv = dbFileVersion.RemoveFileVersionsForFile(file.Id);
                        if (fv)
                        {
                            dbContext.Files.DeleteOnSubmit(nFile);
                            dbContext.SubmitChanges();
                            scope.Complete();
                        }
                        else
                        {
                            scope.Dispose();
                            error = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("File could not be removed. File id: " + nFile.Id + "Error: \n" + e);
                    return false;
                }
                if (error != true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
            throw new NotImplementedException();
        }
    }
}
