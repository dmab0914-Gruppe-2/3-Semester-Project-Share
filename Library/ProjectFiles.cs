using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Library;

namespace Library
{
#pragma warning disable 0169    // disable never used warnings for fields that are being used by LINQ
    [Table(Name = "ProjectFiles")]
    public class ProjectFiles
    {
        [Column(IsPrimaryKey = true, Name = "projectID")]
        private int projectId;
        private EntityRef<Project> _project;
        [Association(IsForeignKey = true, Storage = "_project", ThisKey = "projectId")]
        public Project Project
        {
            get { return _project.Entity; }
            set { _project.Entity = value; }
        }
        [Column(IsPrimaryKey = true, Name = "fileID")]
        private int fileId;
        private EntityRef<File> _file;
        [Association(IsForeignKey = true, Storage = "_file", ThisKey = "fileId")]
        public File File
        {
            get { return _file.Entity; }
            set { _file.Entity = value; }
        }
    }
}
