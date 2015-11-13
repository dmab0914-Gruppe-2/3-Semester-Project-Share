using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class FileController:IFileControler
    {
        public List<Library.File> AllFilesForProject(int projectID)
        {
            throw new NotImplementedException();
        }

        public List<Library.FileVersion> AllVersionsForFile(int fileID)
        {
            throw new NotImplementedException();
        }

        public void GetFile(int fileID)
        {
            throw new NotImplementedException();
        }

        public void UploadFile()
        {
            throw new NotImplementedException();
        }

        public void DeleteFile(int fileID)
        {
            throw new NotImplementedException();
        }

        public void EditFile(int fileID)
        {
            throw new NotImplementedException();
        }
    }
}
