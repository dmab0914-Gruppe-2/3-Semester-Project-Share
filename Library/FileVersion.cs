using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class FileVersion
    {
        private int Id { get; set; }
        private string FilePath { get; set; }
        private double VersionNumber { get; set; }
        private DateTime TimeStamp { get; set; }
        private User Owner { get; set; }

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
