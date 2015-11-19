using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Library;
using Server.Database;

namespace Server
{
    public class FileController : IFileControler
    {
        private DbContext dbContext = new DbContext();
        public List<File> AllFilesForProject(int projectID)
        {
            throw new NotImplementedException();
        }

        public List<FileVersion> AllVersionsForFile(int fileID)
        {
            throw new NotImplementedException();
            
        }

        public File GetFile(int fileID)
        {
            //throw new NotImplementedException();
            //return dbContext.Files.FirstOrDefault(x => x.Id == fileID);
            var query =
                from file in dbContext.Files
                where file.Id == fileID
                select file;
            return query.Single();
        }

        public void UploadFile()
        {

            
            throw new NotImplementedException();
        }

        public void DeleteFile(int fileID)
        {
            throw new NotImplementedException();
            //dbContext.
        }


        public void EditFile(int fileID, User owner)
        {
            File file = GetFile(fileID);
            if (file.FileLock == null)
            {
                dbContext.Files.Context.ExecuteCommand(string.Format(
                "UPDATE dbo.File" +
                "SET FileLock = {0}, FileLockTime = {1}", owner.Id, DateTime.Now));
                //FileVersion fileVersion = dbContext.FileVersions.FirstOrDefault(x => x.Id == fileID);
                //DownloadFile(file); //TODO Uncomment once code is added
                //Thread thread = new Thread(); //TODO Set to waiting thread to start upload once complete
                //thread.Start();
                //thread.Join();
                dbContext.Files.Context.ExecuteCommand(string.Format(
                    "UPDATE dbo.File" +
                    "SET title = '{0}', description = '{1}', versionNr = {2}, FileLock = {3}, FileLockTime = {4}" +
                    "WHERE id = {5}", file.Title, file.Description, file.VersionNr++, null, null, file.Id));
                //dbContext.Files.Context.ExecuteCommand();
                var query =
                    from c in dbContext.Files
                    where c.Id == fileID
                    select file;
                //dbContext.Files.Context.ExecuteQuery(query);
                //dbContext.SubmitChanges();
                UploadFile();
            }
            else
            {
                throw new NotImplementedException();
            }
            
            
        }
    }
}
