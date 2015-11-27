﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.ProjectService;
using Library;

namespace ClientApp
{
    public partial class ProjectAdministration : Form
    {
        private Project activeProject;
        ProjectService.IProjectService projectService = new ProjectServiceClient();
        public ProjectAdministration()
        {
            InitializeComponent();
        }

        private void ProjectAdministration_Load(object sender, EventArgs e)
        {
            //ListView load peoperties...
            //ListView Projects
            listView_Projects.GridLines = true;
            listView_Projects.View = View.Details;
            listView_Projects.FullRowSelect = true;
            //ListView Files and Participants
            listView_FilesParticipants.GridLines = true;
            listView_FilesParticipants.View = View.Details;
            listView_FilesParticipants.FullRowSelect = true;
            //ListView columns
            //listView_Projects.Columns.Add("Id", 30);
            //listView_Projects.Columns.Add("Project", 150);
            //listView_Projects.Columns.Add("Description", 200);
            listView_FilesParticipants.Visible = false;

            label_MembersProject.Visible = false;

            //Set visibility
            label_ProjektId.Visible = false;
            label_Title.Visible = false;
            label_Description.Visible = false;
            textBox_ProjektId.Visible = false;
            textBox_Title.Visible = false;
            textBox_Description.Visible = false;

            //Editable
            textBox_ProjektId.ReadOnly = true;

            //Add data to project table
            Project[] projects = projectService.GetAllProjects();
            foreach (Project project in projects)
            {
                string id = project.Id.ToString();
                string name = project.Title;
                string description = project.Description;
                string[] lwiStrings = { id, name, description };
                ListViewItem lwi = new ListViewItem(lwiStrings);
                listView_Projects.Items.Add(lwi);
            }

        }

        private void button_EditParticipants_Click(object sender, EventArgs e)
        {
            //Visibility
            label_ProjektId.Visible = false;
            label_Title.Visible = false;
            label_Description.Visible = false;
            textBox_ProjektId.Visible = false;
            textBox_Title.Visible = false;
            textBox_Description.Visible = false;

            //label_MembersProject settings
            label_MembersProject.Visible = true;
            label_MembersProject.Text = "Projekt Medlemmer";

            //Listview settings
            listView_FilesParticipants.Visible = true;
            foreach (ColumnHeader column in listView_FilesParticipants.Columns)
            {
                listView_FilesParticipants.Columns.Remove(column);
            }

            listView_FilesParticipants.Columns.Add("Username", 125);
            listView_FilesParticipants.Columns.Add("Email", 200);
            listView_FilesParticipants.Columns.Add("Role", -2);


        }

        private void button_EditProject_Click(object sender, EventArgs e)
        {
            //Edit visibility
            label_ProjektId.Visible = true;
            label_Title.Visible = true;
            label_Description.Visible = true;
            textBox_ProjektId.Visible = true;
            textBox_Title.Visible = true;
            textBox_Description.Visible = true;
            //label_MembersProject settings
            label_MembersProject.Visible = true;
            label_MembersProject.Text = "Projekt indstillinger";
            listView_FilesParticipants.Visible = false;
           


        }

        private void listView_Projects_ItemActivate(object sender, EventArgs e)
        {
            string projectnumber = listView_Projects.SelectedItems[0].Text;
            activeProject = projectService.GetProject(Convert.ToInt32(projectnumber));

            //Users put into listview, starting with Admins
            List<User> projectAdmin = activeProject.ProjectAdministrators;
            //if (projectAdmin.Count != 0)
            //{
            //foreach (User user in projectAdmin)
            //{
            //    string[] row = { user.Username, user.Email, "Administrator" };
            //    ListViewItem lwi = new ListViewItem(row);
            //    listView_FilesParticipants.Items.Add(lwi);
            //}
            //}
            List<User> projectUsers = activeProject.ProjectMembers.ToList();
            if (projectUsers.Count != 0)
            {
                foreach (User user in projectUsers)
                {
                    string[] row = { user.Username, user.Email, "Member" };
                    ListViewItem lwi = new ListViewItem(row);
                    listView_FilesParticipants.Items.Add(lwi);
                }
            }


            textBox_ProjektId.Text = activeProject.Id.ToString();
            textBox_Description.Text = activeProject.Description;
            textBox_Title.Text = activeProject.Title;



        }


    }
}
