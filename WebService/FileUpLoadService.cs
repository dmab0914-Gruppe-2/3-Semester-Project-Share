using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.IO;
using System.Web;
using WebService.Models;
using Server;
using Library;

namespace WebService
{
    class FileUpLoadService : IFileUpLoadService
    {
        private static FileController fCtr = new FileController();
        public void UploadFile(FileUploadMessage request)
        {
            // parameters validation omitted for clarity
            try
            {
                // string basePath = Environment.CurrentDirectory + @"\UploadedFiles\"; // Should place the folder under webService folder in this project but not happing for Nicklas
                string basePath = @"C:\ProjectShare\Uploads\";
                string filenameAndPath = Path.Combine(basePath, request.Metadata.FileName);
                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }

                using (FileStream outfile = new FileStream(filenameAndPath, FileMode.Create))
                {
                    request.FileByteStream.CopyTo(outfile);
                }
            }
            catch (IOException)
            {
                throw;
            }
        }
        public void AddFile(AddSingleFileMessage asfm)
        {
            fCtr.AddFile(asfm.file.Title, asfm.file.Description, asfm.file.Project);
        }
        public FileDownloadReturnMessage DownloadFile(FileDownloadMessage request)
        {
            // parameters validation omitted for clarity
            string localFileName = request.FileMetaData.FullLocalPath;

            try
            {
                Stream fs = new FileStream(localFileName, FileMode.Open);

                return new FileDownloadReturnMessage(new FileMetaData(1, localFileName, localFileName, request.FileMetaData.FileType), fs);
            }
            catch (IOException e)
            {
                throw new FaultException<IOException>(e);
            }
        }
        public List<Library.File> GetAllFilesForProject(int projectId)
        {
            return fCtr.AllFilesForProject(projectId);
        }

        //public void AddMutiFiles(List<String> fileNames, List<String> fileDescs, Library.Project project)
        public void AddMultiFiles(AddMultiFilesMessage amfm)
        {
            fCtr.AddMutiFiles(amfm.filenames.ToList<string>(), amfm.filedescs.ToList<string>(), amfm.project);
        }
        public GetFIleReturnMessage GetFile(GetFileMessage gfm)
        {
            Library.File file = null;
            file = fCtr.GetFile(gfm.Metadata.FileId);
            GetFIleReturnMessage gfrm = new GetFIleReturnMessage();
            gfrm.file = file;
            return gfrm;
        }

        //public Library.FileVersion EditFile(Library.User owner)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
