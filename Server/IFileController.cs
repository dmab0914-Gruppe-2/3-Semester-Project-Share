using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library;

namespace Server
{
    interface IFileController
    {
        List<File> AllFilesForProject(int projectID);
        List<FileVersion> AllVersionsForFile(int fileID);
        void AddFile(string fileName, string fileDesc, Project project);
        void AddMutiFiles(List<String> fileNames, List<String> fileDescs, Project project);
        void DeleteFile(int fileID);
        File GetFile(int fileId);
        void EditFile(int fileId, User owner);
    }
}
