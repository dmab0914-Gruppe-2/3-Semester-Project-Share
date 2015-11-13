using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class FileVersion
    {
        private string FilePath { get; set; }
        private double VersionNumber { get; set; }
        private DateTime TimeStamp { get; set; }
        private User Owner { get; set; }

    }
}
