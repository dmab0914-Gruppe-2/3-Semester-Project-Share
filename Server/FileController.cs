using Library;
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
        public void AddFile(string fileName, string fileDesc)
        {
            File file = new File(fileName, fileDesc);

            try
            {
                // add to db layer
            }
            catch (Exception e)
            {
                throw new Exception("File not added to DB " + e);
            }
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
