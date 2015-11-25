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
                    const int bufferSize = 65536; // 64K
                    Byte[] buffer = new Byte[bufferSize];
                    int bytesRead = request.FileByteStream.Read(buffer, 0, bufferSize);

                    while (bytesRead > 0)
                    {
                        outfile.Write(buffer, 0, bytesRead);
                        bytesRead = request.FileByteStream.Read(buffer, 0, bufferSize);
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public FileDownloadReturnMessage DownloadFile(FileDownloadMessage fdm)
        {
            throw new NotImplementedException();
        }

        public void AddFile(string fileName, string fileDesc)
        {
            fCtr.AddFile(fileName, fileDesc);
        }


        //public Library.FileVersion EditFile(Library.User owner)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
