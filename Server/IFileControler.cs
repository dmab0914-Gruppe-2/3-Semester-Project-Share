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
<<<<<<< HEAD
        List<File> AllFilesForProject(int projectID);
        List<FileVersion> AllVersionsForFile(int fileID);
        void GetFile(int fileID);
        void AddFile(string fileName, string fileDesc);
        void DeleteFile(int fileID);
        void EditFile(int fileID);


=======
        List<File> AllFilesForProject(int projectId);
        List<FileVersion> AllVersionsForFile(int fileId);
        File GetFile(int fileId);
        void UploadFile();
        void DeleteFile(int fileId);
        void EditFile(int fileId, User owner);
>>>>>>> refs/remotes/origin/master
    }
}
