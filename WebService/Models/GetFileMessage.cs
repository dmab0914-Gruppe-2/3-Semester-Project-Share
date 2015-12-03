using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Models
{
    [MessageContract]
    public class GetFileMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public FileMetaData Metadata;
    }
}
