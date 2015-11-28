using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    class FileService:IFileService
    {
        private static FileController fCtr = new FileController();
        public void AddFile(string fileName, string fileDesc)
        {
            fCtr.AddFile(fileName, fileDesc);
        }
    }
}
