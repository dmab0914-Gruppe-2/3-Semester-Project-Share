using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Models
{
    [DataContract]
    public class FileMetaData
    {
        public FileMetaData(int id)
        {
            this.FileId = id;
        }
        public FileMetaData(string FullLocalPath, string FileName)
        {
            this.FullLocalPath = FullLocalPath;
            this.FileName = FileName;
            this.FileType = DefinedFileTypes.GENERIC;
        }

        public FileMetaData(string FullLocalPath, string FileName, DefinedFileTypes fileType)
        {
            this.FullLocalPath = FullLocalPath;
            this.FileName = FileName;
            this.FileType = fileType;
        }
        public FileMetaData(int fileId, string FullLocalPath, string FileName)
        {
            this.FileId = fileId;
            this.FullLocalPath = FullLocalPath;
            this.FileName = FileName;
            this.FileType = DefinedFileTypes.GENERIC;
        }
        public FileMetaData(int fileId, string FullLocalPath, string FileName, DefinedFileTypes fileType)
        {
            this.FileId = fileId;
            this.FullLocalPath = FullLocalPath;
            this.FileName = FileName;
            this.FileType = fileType;
        }

        [DataMember(Name = "FileType", Order = 0, IsRequired = true)]
        public DefinedFileTypes FileType;
        [DataMember(Name = "FullLocalPath", Order = 1, IsRequired = false)]
        public string FullLocalPath;
        [DataMember(Name = "FileName", Order = 2, IsRequired = false)]
        public string FileName;
        [DataMember(Name = "FileId", Order = 3, IsRequired = true)]
        public int FileId;
    }
}
