using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace Library
{
    [Table]
    public class FileVersion
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string FilePath { get; set; }
        [Column]
        public int FileId { get; set; }
        [Column]
        public int VersionNumber { get; set; }
        [Column]
        public DateTime TimeStamp { get; set; }
        [Column]
        public int Owner { get; set; }

        public FileVersion(string filePath, int versionNumber, User owner)
        {
            FilePath = filePath;
            VersionNumber = versionNumber;
            TimeStamp = DateTime.Now;
            Owner = owner.Id;
        }
        public FileVersion(string filePath, File file, int versionNumber, User owner)
        {
            FilePath = filePath;
            FileId = file.Id;
            VersionNumber = versionNumber;
            TimeStamp = DateTime.Now;
            Owner = owner.Id;
        }

        public FileVersion(int id, string filePath, int versionNumber, User owner)
        {
            Id = id;
            FilePath = filePath;
            VersionNumber = versionNumber;
            TimeStamp = DateTime.Now;
            Owner = owner.Id;
        }

        public FileVersion(int id, string filePath, int versionNumber, DateTime timeStamp, User owner)
        {
            Id = id;
            FilePath = filePath;
            VersionNumber = versionNumber;
            TimeStamp = timeStamp;
            Owner = owner.Id;
        }
    }
}
