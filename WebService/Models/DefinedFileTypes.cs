using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Models
{
    [DataContract]
    public enum DefinedFileTypes
    {
        [EnumMember]
        DOC,
        [EnumMember]
        DOCX,
        [EnumMember]
        PDF,
        [EnumMember]
        RTF,
        [EnumMember]
        jpg,
        [EnumMember]
        png,
        [EnumMember]
        GENERIC
    }
}
