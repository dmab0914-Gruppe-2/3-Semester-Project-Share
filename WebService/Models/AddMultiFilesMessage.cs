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
    public class AddMultiFilesMessage
    {
        [MessageBodyMember(Order = 0)]
        public string[] filenames { get; set; }
        [MessageBodyMember(Order = 1)]
        public string[] filedescs { get; set; }
        [MessageBodyMember(Order = 3)]
        public Project project { get; set; }
    }
}
