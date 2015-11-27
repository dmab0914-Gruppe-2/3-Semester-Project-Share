using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Server.Database
{
    interface IDbFileVersion
    {
        List<FileVersion> GetFilesVersionForFile(int fileId);
        FileVersion GetNewsFileVersion(int fileId);
        bool AddFileVersion(FileVersion fileVersion);
    }
}
