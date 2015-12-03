using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Models
{
    [MessageContract]
    public class FileListReturnMessage
    {
        [MessageBodyMember(Order = 0)]
        public string[] FilePathList { get; set; }
    }
}
