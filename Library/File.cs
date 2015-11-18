using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class File
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int VersionNr { get; set; }
        public User FileLock { get; set; }
        public DateTime FileLockTime { get; set; }
        private List<FileVersion> SubFiles { get; set; }

        public File()
        {
            FileLock = null;
            FileLockTime = DateTime.Now;
            SubFiles = new List<FileVersion>();
        }

        public File(string title, string description)
        {
            Title = title;
            Description = description;
            VersionNr = 1;
            FileLock = null;
            FileLockTime = DateTime.Now;
            SubFiles = new List<FileVersion>();
        }

        public File(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            VersionNr = 1;
            FileLock = null;
            FileLockTime = DateTime.Now;
            SubFiles = new List<FileVersion>();
        }

        public File(int id, string title, string description, int verionNr, User fileLock, DateTime fileLockTime)
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
