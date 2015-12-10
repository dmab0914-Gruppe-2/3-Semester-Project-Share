using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Server.Database;
using System.Transactions;

namespace Server
{
    public class FileController : IFileController
    {
        private DbContext dbContext;
        private DbFile dbFile;
        private DbFileVersion dbFileVersion;

        public FileController()
        {
            dbContext = new DbContext();
            dbFile = new DbFile();
            dbFileVersion = new DbFileVersion();
        }
        public List<File> AllFilesForProject(int projectID)
        {
            return dbFile.GetAllFilesForProject(projectID);
        }

        public List<FileVersion> AllVersionsForFile(int fileID)
        {
            throw new NotImplementedException();

        }

        public File GetFile(int fileID)
        {
            return dbFile.GetFile(fileID);
        }
        public int AddFile(string fileName, string fileDesc, int projectid)
        {
            Project project = new Library.Project();
            project.Id = projectid;
            File file = new File(fileName, fileDesc, project);
            User owner = new Library.User(1);
            try
            {
                file.FileLock = 1;
                file.FileLockTime = DateTime.Now;
                file.VersionNr = 1;
                var option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    bool f = dbFile.AddFIle(file);
                    FileVersion fv = new FileVersion(file.Id.ToString(), file, file.VersionNr, owner);

                    bool version = dbFileVersion.AddFileVersion(fv);

                    if (version && f)
                        scope.Complete();
                }
                return file.Id;
            }
            catch (Exception e)
            {
                throw new Exception("File not added to DB " + e);
            }
        }

        public void DeleteFile(int fileID)
        {
            // remeber to use transaction to make sure file is delete every where or no where !
            throw new NotImplementedException();
            //dbContext.
        }


        public void EditFile(int fileID, User owner)
        {
           
        }


        public List<int> AddMutiFiles(List<string> fileNames, List<string> fileDescs, Library.Project project)
        {
            List<int> ids = new List<int>();
            List<File> files = new List<File>();
            User owner = new Library.User(1);
            int i = 0;
            try
            {
                foreach (String fn in fileNames)
                {
                    File file = new File(fn, fileDescs[i], project);
                    file.FileLock = 1;
                    file.FileLockTime = DateTime.Now;
                    file.VersionNr = 1;
                    files.Add(file);
                    i++;
                }
                var option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    foreach (File f in files)
                    {
                        bool af = dbFile.AddFIle(f);
                        FileVersion fv = new FileVersion(f.Id.ToString(), f, f.VersionNr, owner);
                        bool version = dbFileVersion.AddFileVersion(fv);
                        if (!af && !version)
                        {
                            scope.Dispose();
                            break;
                        }
                        ids.Add(f.Id);
                    }
                    scope.Complete();
                }
                return ids;
            }
            catch (Exception e)
            {
                throw new Exception("Files not added to DB: \n" + e);
            }
        }
    }
}
