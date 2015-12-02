using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Library;
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
        public void AddFile(string fileName, string fileDesc, Project project)
        {
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
            //File file = GetFile(fileID);
            //if (file.FileLock == null)
            //{
            //    dbFile.Files.Context.ExecuteCommand(string.Format(
            //    "UPDATE dbo.File" +
            //    "SET FileLock = {0}, FileLockTime = {1}", owner.Id, DateTime.Now));
            //    //FileVersion fileVersion = dbContext.FileVersions.FirstOrDefault(x => x.Id == fileID);
            //    //DownloadFile(file); //TODO Uncomment once code is added
            //    //Thread thread = new Thread(); //TODO Set to waiting thread to start upload once complete
            //    //thread.Start();
            //    //thread.Join();
            //    dbFile.Files.Context.ExecuteCommand(string.Format(
            //        "UPDATE dbo.File" +
            //        "SET title = '{0}', description = '{1}', versionNr = {2}, FileLock = {3}, FileLockTime = {4}" +
            //        "WHERE id = {5}", file.Title, file.Description, file.VersionNr++, null, null, file.Id));
            //    //dbContext.Files.Context.ExecuteCommand();
            //    var query =
            //        from c in dbFile.Files
            //        where c.Id == fileID
            //        select file;
            //    //dbContext.Files.Context.ExecuteQuery(query);
            //    //dbContext.SubmitChanges();


            //   // UploadFile();
            //}
            //else
            //{
            //    throw new NotImplementedException();
            //}


        }


        public void AddMutiFiles(List<string> fileNames, List<string> fileDescs, Library.Project project)
        {
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
                    }
                    scope.Complete();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Files not added to DB: \n" + e);
            }
        }
    }
}
