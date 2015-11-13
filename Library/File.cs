using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class File
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private double VersionNr { get; set; }
        private User FileLock { get; set; }
        private DateTime FileLockTime { get; set; }
        private List<FileVersion> SubFiles { get; set; }
    }
}
