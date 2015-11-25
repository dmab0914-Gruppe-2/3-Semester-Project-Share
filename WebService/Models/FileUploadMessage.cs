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
    public class FileUploadMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public FileMetaData Metadata;
        [MessageBodyMember(Order = 1)]
        public Stream FileByteStream;
    }
}
