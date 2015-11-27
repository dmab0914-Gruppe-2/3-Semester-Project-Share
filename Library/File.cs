using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Table(Name = "File")]
    public class File
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string Title { get; set; }
        [Column]
        public string Description { get; set; }
        [Column]
        public int VersionNr { get; set; }
        [Column]
        public int FileLock { get; set; }
        [Column]
        public DateTime FileLockTime { get; set; }
        
        private List<FileVersion> SubFiles { get; set; }

        public File()
        {
            FileLock = 0;
            FileLockTime = DateTime.Now;
            SubFiles = new List<FileVersion>();
        }

        public File(string title, string description)
        {
            Title = title;
            Description = description;
            VersionNr = 1;
            FileLock = 0;
            FileLockTime = DateTime.Now;
            SubFiles = new List<FileVersion>();
        }

        public File(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            VersionNr = 1;
            FileLock = 0;
            FileLockTime = DateTime.Now;
            SubFiles = new List<FileVersion>();
        }

        public File(int id, string title, string description, int verionNr, int fileLock, DateTime fileLockTime)
        {
            Id = id;
            Title = title;
            Description = description;
            VersionNr = verionNr;
            FileLock = fileLock;
            FileLockTime = fileLockTime;
            SubFiles = new List<FileVersion>();
        }
    }
}
