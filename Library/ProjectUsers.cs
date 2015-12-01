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
    [Table(Name = "ProjectUsers")]
    public class ProjectUsers
    {
        //public ProjectUsers()
        //{

        //}

        //public ProjectUsers(Project project, User user, UserType userType)
        //{
        //    this.Project = project;
        //    this.User = user;
        //    this.UserType = userType;
        //}

        [Column(IsPrimaryKey = true, Name = "projectID")]
        private int projectId;
        private EntityRef<Project> _project;
        [Association(IsForeignKey = true, Storage = "_project", ThisKey = "projectId")]
        public Project Project
        {
            get { return _project.Entity; }
            set { _project.Entity = value; }
        }

        [Column(IsPrimaryKey = true, Name = "userID")]
        private int userId;
        private EntityRef<User> _user;
        [Association(IsForeignKey = true, Storage = "_user", ThisKey = "userId")]
        public User User
        {
            get { return _user.Entity; }
            set { _user.Entity = value; }
        }

        [Column(IsPrimaryKey = false, Name = "userTypeID")]
        public UserType UserType { get; set; }
    }
}
