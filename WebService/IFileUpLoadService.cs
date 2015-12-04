using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Runtime.Serialization;
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
        void AddFile(AddSingleFileMessage asfm);
        [OperationContract]
        FileDownloadReturnMessage DownloadFile(FileDownloadMessage fdm);
        [OperationContract]
        List<File> GetAllFilesForProject(int projectId);
        [OperationContract]
        File getFileById(int fileID);
        [OperationContract]
        void AddMultiFiles(AddMultiFilesMessage amfm);
        [OperationContract]
        GetFIleReturnMessage GetFile(GetFileMessage gfm);
        //  [OperationContract]
        // FileVersion EditFile(User owner);
    }
}
