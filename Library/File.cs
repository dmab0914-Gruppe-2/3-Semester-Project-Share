﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Library
{
#pragma warning disable 0169        // disable never used warnings for fields that are being used by LINQ

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

        [Column(Name = "projectID")] private int _projectId;
        private EntityRef<Project> _project = new EntityRef<Project>();
        [Association(IsForeignKey = true, Storage = "_project", ThisKey = "_projectId")]
        public Project Project
        {
            get { return _project.Entity; }
            set { _project.Entity = value; }
        }
        
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
