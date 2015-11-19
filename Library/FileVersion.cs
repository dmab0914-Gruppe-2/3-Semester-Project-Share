using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace Library
{
    [Table(Name = "FileVersion")]
    public class FileVersion
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string FilePath { get; set; }
<<<<<<< HEAD
        [Column]
        public int VersionNumber { get; set; }
        [Column]
=======
        public int VersionNumber { get; set; }
>>>>>>> refs/remotes/origin/master
        public DateTime TimeStamp { get; set; }
        [Column]
        public User Owner { get; set; }

        public FileVersion(string filePath, int versionNumber, User owner)
        {
            FilePath = filePath;
            VersionNumber = versionNumber;
            TimeStamp = DateTime.Now;
            Owner = owner;
        }

        public FileVersion(int id, string filePath, int versionNumber, User owner)
        {
            Id = id;
            FilePath = filePath;
            VersionNumber = versionNumber;
            TimeStamp = DateTime.Now;
            Owner = owner;
        }

        public FileVersion(int id, string filePath, int versionNumber, DateTime timeStamp, User owner)
        {
            Id = id;
            FilePath = filePath;
            VersionNumber = versionNumber;
            TimeStamp = timeStamp;
            Owner = owner;
        }
    }
}
