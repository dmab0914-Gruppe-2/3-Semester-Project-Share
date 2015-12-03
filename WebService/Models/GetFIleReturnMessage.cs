using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Models
{
    [MessageContract]
    public class GetFIleReturnMessage
    {
        [MessageBodyMember(Order = 0)]
        public File file { get; set; }
    }
}
