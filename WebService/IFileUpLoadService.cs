using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Library;
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
        List<File> GetAllFilesForProject(int projectId);

        [OperationContract]
        void AddFile(string fileName, string fileDesc);
        [OperationContract]
        File GetFile(int fileId);
      //  [OperationContract]
       // FileVersion EditFile(User owner);
    }
}
