using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class FileVersion
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public double VersionNumber { get; set; }
        public DateTime TimeStamp { get; set; }
        public User Owner { get; set; }

        public FileVersion(string filePath, double versionNumber, User owner)
        {
            FilePath = filePath;
            VersionNumber = versionNumber;
            TimeStamp = DateTime.Now;
            Owner = owner;
        }

        public FileVersion(int id, string filePath, double versionNumber, User owner)
        {
            Id = id;
            FilePath = filePath;
            VersionNumber = versionNumber;
            TimeStamp = DateTime.Now;
            Owner = owner;
        }

        public FileVersion(int id, string filePath, double versionNumber, DateTime timeStamp, User owner)
        {
            Id = id;
            FilePath = filePath;
            VersionNumber = versionNumber;
            TimeStamp = timeStamp;
            Owner = owner;
        }
    }
}
