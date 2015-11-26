using System;
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
            
            //Add data to project table
            Project[] projects = projectService.GetAllProjects();
            foreach (Project project in projects)
            {
                string id = project.Id.ToString();
                string name = project.Title;
                string description = project.Description;
                string[] lwiStrings = {id, name, description};
                ListViewItem lwi = new ListViewItem(lwiStrings);
                listView_Projects.Items.Add(lwi);
            }

        }

        private void button_EditParticipants_Click(object sender, EventArgs e)
        {
            
            foreach (ColumnHeader column in listView_FilesParticipants.Columns)
            {
                listView_FilesParticipants.Columns.Remove(column);
            }

            listView_FilesParticipants.Columns.Add("Username", 125);
            listView_FilesParticipants.Columns.Add("Email", 200);
            listView_FilesParticipants.Columns.Add("Role", -2);


        }

        private void button_EditFiles_Click(object sender, EventArgs e)
        {
            foreach (ColumnHeader column in listView_FilesParticipants.Columns)
            {
                listView_FilesParticipants.Columns.Remove(column);
            }

            listView_FilesParticipants.Columns.Add("Filename", 125);
            listView_FilesParticipants.Columns.Add("Description", 200);
            listView_FilesParticipants.Columns.Add("Lock", 50);



        }


    }
}
