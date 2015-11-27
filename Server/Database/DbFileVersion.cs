using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(item != null)
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
                return false;
            }
        }
    }
}
