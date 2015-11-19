using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class File : IFile
    {
        static FileController fCtr = new FileController();
        public FilePrepare Prepare(FilePrepare Fpp)
        {
            return Fpp;
        }

        public void Upload()
        {
            throw new NotImplementedException();
        }
    }
}
