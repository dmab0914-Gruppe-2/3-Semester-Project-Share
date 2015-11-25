using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Models
{
    [MessageContract]
    public class FileDownloadReturnMessage
    {
        public FileDownloadReturnMessage(FileMetaData metaData, Stream stream)
        {
            this.DownloadedFileMetadata = metaData;
            this.FileByteStream = stream;
        }

        [MessageHeader(MustUnderstand = true)]
        public FileMetaData DownloadedFileMetadata;
        [MessageBodyMember(Order = 1)]
        public Stream FileByteStream;
    }
}
