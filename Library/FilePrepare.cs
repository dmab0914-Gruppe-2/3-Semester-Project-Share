using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class FilePrepare
    {
        public string FileName { get; set; }
        public int ProjectId { get; set; }
        public int serverport { get; set; }

        public FilePrepare()
        {
            FileName = "";
            ProjectId = 0;
            serverport = 0;
        }
        public FilePrepare(string fn, int pid, int sp)
        {
            this.FileName = fn;
            this.ProjectId = pid;
            this.serverport = sp;
        }
    }
}
