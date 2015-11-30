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
        void AddFile(string fileName, string fileDesc, int projectID);
        void DeleteFile(int fileID);
        File GetFile(int fileId);
        void EditFile(int fileId, User owner);
    }
}
