using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Library;

namespace WebService
{
    
    [ServiceContract]
    public interface IServiceFileController
    {
        [OperationContract]
        FileVersion EditFile(User owner);
        
    }
}
