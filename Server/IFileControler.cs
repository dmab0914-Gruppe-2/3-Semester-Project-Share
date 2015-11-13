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
        List<File> AllFilesForProject(int projectID);
        List<FileVersion> AllVersionsForFile(int fileID);
        void GetFile(int fileID);
        void UploadFile();
        void DeleteFile(int fileID);
        void EditFile(int fileID);
    }
}
