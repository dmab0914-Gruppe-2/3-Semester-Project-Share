using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library;

namespace Server
{
    interface IFileControler
    {
        List<File> AllFilesForProject(int projectId);
        List<FileVersion> AllVersionsForFile(int fileId);
        File GetFile(int fileId);
        void UploadFile();
        void DeleteFile(int fileId);
        void EditFile(int fileId, User owner);
    }
}
