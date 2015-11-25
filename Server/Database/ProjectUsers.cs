﻿using System;
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
    [Table(Name = "ProjectUsers")]
    internal class ProjectUsers
    {
        [Column(IsPrimaryKey = true, Name = "userID")] private int userId;
        private EntityRef<User> _user = new EntityRef<User>();
        [Association(IsForeignKey = true, Storage = "_user", ThisKey = "userId")]
        public User User
        {
            get { return _user.Entity; } 
            set { _user.Entity = value; }
        }

        [Column(IsPrimaryKey = true, Name = "projectID")]
        private int projectId;
        private EntityRef<Project> _project = new EntityRef<Project>();
        [Association(IsForeignKey = true, Storage = "_project", ThisKey = "projectId")]
        public Project Project
        {
            get { return _project.Entity; }
            set { _project.Entity = value; }
        }
    }
}
