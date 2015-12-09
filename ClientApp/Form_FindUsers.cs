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
using ClientApp.UserService;
using Library;

namespace ClientApp
{
    public partial class Form_FindUsers : Form
    {
        //Services
        ProjectService.IProjectService projectService = new ProjectServiceClient();
        UserService.IUserService userService = new UserServiceClient();

        //Class variables
        private int projectId;
        private bool createProject;

        public Form_FindUsers(int projectId, bool createProject)
        {
            InitializeComponent();
            this.projectId = projectId;
            this.createProject = createProject;
        }

        private void button_FindUser_Click(object sender, EventArgs e)
        {
            bool multiParameter = false;

        }

        private void Form_FindUsers_Load(object sender, EventArgs e)
        {
            
            //Listview settings
            listView_Users.GridLines = true;
            listView_Users.FullRowSelect = true;
            listView_Users.View = View.Details;

            //Listview columns
            listView_Users.Columns.Add("Id", 25);
            listView_Users.Columns.Add("Username", 150);
            listView_Users.Columns.Add("Email", 150);

            User[] allUsers = userService.FindAllUsers();
            foreach (User user in allUsers)
            {
                string[] row = {user.Id.ToString(), user.Username, user.Email};
                ListViewItem lwi = new ListViewItem(row);
                listView_Users.Items.Add(lwi);
            }
        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            bool success;

            if (listView_Users.SelectedItems.Count == 1)
            {
                int id = Convert.ToInt32(listView_Users.SelectedItems[0].Text);
                User user = userService.FindUserById(id);
                success = projectService.AddUserToProject(projectId, user);
                if (success)
                    MessageBox.Show("Bruger tilføjet!");
                else
                    MessageBox.Show("Fejl");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
