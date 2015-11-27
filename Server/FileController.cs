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
    public class FileController : IFileControler
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
        public void AddFile(string fileName, string fileDesc)
        {
            File file = new File(fileName, fileDesc);
            User owner = new Library.User();
            owner.Id = 1;
            try
            {
                file.FileLock = 1;
                file.FileLockTime = DateTime.Now;
                file.VersionNr = 1;
                // lock tables before start
                // 1st add file to db with DbFiles
                // create fileversion WITH FILE ID and max version nr +1
                // add fileVersion to db with DbFileVersion
                // submit and unlock
                var option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;
                option.Timeout = TimeSpan.FromSeconds(30);

                 using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, option))
                 {
                     dbFile.AddFIle(file);

                     FileVersion fv = new FileVersion(file.Id.ToString(), file, file.VersionNr, owner);

                     dbFileVersion.AddFileVersion(fv);

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
    }
}
