using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.ServiceModel;

namespace WebService
{
    [ServiceContract]
    interface IFileService
    {
        [OperationContract]
        void AddFile(string fileName, string fileDesc, int projectId);

    }
}
