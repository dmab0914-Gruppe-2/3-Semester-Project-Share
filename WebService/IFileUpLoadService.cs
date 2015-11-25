using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WebService.Models;

namespace WebService
{
    [ServiceContract]
    interface IFileUpLoadService
    {
        [OperationContract]
        void UploadFile(FileUploadMessage fum); //MUST return void

        [OperationContract]
        FileDownloadReturnMessage DownloadFile(FileDownloadMessage fdm);

        [OperationContract]
        void AddFile(string fileName, string fileDesc);
    }
}
