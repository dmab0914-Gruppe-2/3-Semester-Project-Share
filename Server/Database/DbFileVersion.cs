using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Server.Database
{
    class DbFileVersion : IDbFileVersion
    {
        private DbContext dbContext;
        public DbFileVersion()
        {
            dbContext = new DbContext();
        }
        public List<FileVersion> GetFilesVersionForFile(int fileId)
        {
            var item = from fv in dbContext.FileVersions
                       where fv.FileId == fileId
                       select fv;
            if (item != null)
            {
                return item.ToList();
            }
            return null;
        }

        public FileVersion GetNewsFileVersion(int fileId)
        {
            var item = dbContext.FileVersions.Where(i => i.FileId == fileId).
                OrderByDescending(i => i.VersionNumber).
                First();
            if (item != null)
            {
                return item;
            }
            return null;
        }

        public bool AddFileVersion(FileVersion fileVersion)
        {
            try
            {
                dbContext.FileVersions.InsertOnSubmit(fileVersion);
                dbContext.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("fejl: " + e);
                return false;
            }
        }

        public bool RemoveFileVersionsForFile(int fileId)
        {
            try
            {
                var option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    var fileVersions = from fv in dbContext.FileVersions
                                       where fv.FileId == fileId
                                       select fv;
                    foreach (FileVersion fileVersion in fileVersions)
                    {
                        dbContext.FileVersions.DeleteOnSubmit(fileVersion);
                    }
                    dbContext.SubmitChanges();
                    scope.Complete();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Fileversion for file could not be removed. File id: " + fileId + "Error: \n" + e);
                return false;
            }
        }
    }
}
