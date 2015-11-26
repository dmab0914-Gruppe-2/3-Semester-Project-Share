using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Database
{
    interface IDbFile
    {
        List<File> GetAllFilesForProject(int projectId);
        File GetFile(int fileId);
        int AddFIle(string fileName, string description, int versionNr, User fileLock);
    }
}
