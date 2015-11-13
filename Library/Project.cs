using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Project
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private string ProjectFolder { get; set; }
        private List<User> ProjectMembers { get; set; }
        private List<User> ProjectAdministrators { get; set; }
        private List<File> ProjectFiles { get; set; }
    }
}
