using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Library;

namespace Server.DBJoinTables
{
    [Table]
    class ProjectUsers
    {
        [Column(IsPrimaryKey = true)] private int projectId;
        private EntityRef<Project> _project = new EntityRef<Project>();
        [Association(Name = "projectID", IsForeignKey = true,Storage = "_project", ThisKey = "projectID")]
        public Project Project { get; set; }
    }
}
