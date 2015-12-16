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
    public partial class ProjectAdministration : Form
    {
        internal User projectAdmin;
        private Project activeProject;

        ProjectService.IProjectService projectService = new ProjectServiceClient();
        UserService.IUserService userService = new UserServiceClient();
        public ProjectAdministration()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Settings for the window being set when loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            listView_ProjectAdmin.View = View.Details;
            listView_ProjectAdmin.GridLines = true;
            listView_ProjectAdmin.FullRowSelect = true;
            listView_ProjectAdmin.Columns.Add("Id", 30);
            listView_ProjectAdmin.Columns.Add("Navn", 150);
            listView_ProjectAdmin.Columns.Add("Email", 200);
            listView_FilesParticipants.Visible = false;
            label_MembersProject.Visible = false;

            //Set visibility
            label_ProjektId.Visible = false;
            label_Title.Visible = false;
            label_Description.Visible = false;
            label_Directory.Visible = false;
            textBox_ProjektId.Visible = false;
            textBox_Title.Visible = false;
            textBox_Description.Visible = false;
            button_Save.Visible = false;
            button_FindUser.Visible = false;
            textbox_Directory.Visible = false;
            listView_ProjectAdmin.Visible = false;
            label_ProjectAdmin.Visible = false;
            button_PromoteDemote.Visible = false;

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

        private void ResetVisibility()
        {
            label_ProjektId.Visible = false;
            label_Title.Visible = false;
            label_Description.Visible = false;
            textBox_ProjektId.Visible = false;
            textBox_Title.Visible = false;
            label_Directory.Visible = false;
            textbox_Directory.Visible = false;
            textBox_Description.Visible = false;
            button_PromoteDemote.Visible = false;
            button_Save.Visible = false;
            button_FindUser.Visible = false;
            listView_ProjectAdmin.Visible = false;
            label_ProjectAdmin.Visible = false;
            listView_FilesParticipants.Visible = false;
            button_Save.Visible = false;
            button_FindUser.Visible = false;

            //Reset text boxes.
            textBox_ProjektId.Clear();
            textBox_Title.Clear();
            textBox_Description.Clear();
            textbox_Directory.Clear();
        }

        /// <summary>
        /// Visibility modifiers and listview settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_EditParticipants_Click(object sender, EventArgs e)
        {
            //Visibility
            ResetVisibility();
            button_FindUser.Visible = true;
            button_Save.Visible = true;

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

        /// <summary>
        /// Visibility modifiers set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_EditProject_Click(object sender, EventArgs e)
        {
            ResetVisibility();
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
            label_Directory.Visible = true;
            textbox_Directory.Visible = true;
        }

        private void listView_Projects_ItemActivate(object sender, EventArgs e)
        {
            string projectnumber = listView_Projects.SelectedItems[0].Text;
            activeProject = projectService.GetProject(Convert.ToInt32(projectnumber));
            UpdateProjects(false);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            bool accepted;
            if (activeProject != null)
            {
                if (listView_Projects.SelectedItems.Count == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil gemme disse ændringer?", "Gem ændringer for projekt", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (textBox_Title.Text.Equals(""))
                        {
                            MessageBox.Show("Titel kan ikke være tom!");
                            accepted = false;
                        }
                        else if (textBox_Description.Text.Equals(""))
                        {
                            MessageBox.Show("Beskrivelse kan ikke være tom");
                            accepted = false;
                        }
                        else
                        {
                            accepted = true;
                        }

                        if (accepted)
                        {
                            int projectId = Convert.ToInt32(textBox_ProjektId.Text);
                            //TODO Uncomment when ready after project users have been modified
                            //Project project = new Project(projectId, textBox_Title.Text, textBox_Description.Text);
                            Project project = new Project
                            {
                                Description = textBox_Description.Text,
                                Title = textBox_Title.Text
                            };
                            bool success = projectService.UpdateProject(projectId, textBox_Title.Text, textBox_Description.Text, textbox_Directory.Text);
                            if (success)
                                MessageBox.Show("Success");
                            else
                                MessageBox.Show("Fail");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Du valgte nej");
                    }
                }
            }
            else if (activeProject == null)
            {
                string title = textBox_Title.Text;
                string desc = textBox_Description.Text;
                string directory = textbox_Directory.Text;

                ProjectReturnType returnType = projectService.AddProject(title, desc, directory, projectAdmin);

                if (returnType == ProjectReturnType.Success)
                    MessageBox.Show("Projekt oprettet!");
                else if (returnType == ProjectReturnType.TitleMissing)
                    MessageBox.Show("Titel mangler!");
                else if (returnType == ProjectReturnType.DescriptionMissing)
                    MessageBox.Show("Beskrivelse mangler!");
                else if (returnType == ProjectReturnType.ProjectAdministratorUserMissing)
                    MessageBox.Show("Projekt Administrator mangler!");
            }
        }

        private void button_FindUser_Click(object sender, EventArgs e)
        {
            try
            {
                Form_FindUsers findusers = new Form_FindUsers(Convert.ToInt32(listView_Projects.SelectedItems[0].Text), false);
                findusers.ShowDialog();
                UpdateProjects(false);
            }
            catch
            {
                MessageBox.Show("Select project first");
            }
           
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            UpdateProjects(true);
        }



        private void UpdateProjects(bool projectSelect)
        {
            //Projects
            if (projectSelect)
            {
                foreach (ListViewItem item in listView_Projects.Items)
                {
                    item.Remove();
                }
                Project[] projects = projectService.GetAllProjects();
                foreach (Project project in projects)
                {
                    string id = project.Id.ToString();
                    string title = project.Title;
                    string desc = project.Description;
                    string[] row = { id, title, desc };
                    ListViewItem lwi = new ListViewItem(row);
                    listView_Projects.Items.Add(lwi);
                }
            }

            //Project settings for active project
            foreach (ListViewItem listViewItem in listView_FilesParticipants.Items)
            {
                listViewItem.Remove();
            }

            //Users put into listview, starting with Admins
            if (activeProject != null)
            {
                List<User> projectAdmin = activeProject.ProjectAdministrators;
                if (projectAdmin.Count != 0)
                {
                    foreach (User user in projectAdmin)
                    {
                        string[] row = { user.Username, user.Email, "Administrator" };
                        ListViewItem lwi = new ListViewItem(row);
                        listView_FilesParticipants.Items.Add(lwi);
                    }
                }

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

        private void button_CreateProject_Click(object sender, EventArgs e)
        {
            ResetVisibility();
            activeProject = null;
            UpdateProjects(false);
            //Edit visibility
            label_ProjektId.Visible = true;
            label_Title.Visible = true;
            label_Description.Visible = true;
            textBox_ProjektId.Visible = true;
            textBox_Title.Visible = true;
            textBox_Description.Visible = true;
            button_Save.Visible = true;
            button_FindUser.Visible = true;
            label_ProjectAdmin.Visible = true;
            listView_ProjectAdmin.Visible = true;
            //label_MembersProject settings
            label_MembersProject.Visible = true;
            label_MembersProject.Text = "Opret Projekt";
            label_Directory.Visible = true;
            textbox_Directory.Visible = true;

            User[] users = userService.FindAllUsers();
            listView_ProjectAdmin.Items.Clear();
            foreach (User user in users)
            {
                string id = user.Id.ToString();
                string name = user.Username;
                string email = user.Email;
                string[] row = { id, name, email };
                ListViewItem lwi = new ListViewItem(row);
                listView_ProjectAdmin.Items.Add(lwi);
            }
        }

        private void listView_ProjectAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_ProjectAdmin.SelectedItems.Count == 1)
            {
                ListViewItem.ListViewSubItemCollection rowCollection = listView_ProjectAdmin.SelectedItems[0].SubItems;
                string id = rowCollection[0].Text;
                string name = rowCollection[1].Text;
                label_ProjectAdmin.Text = string.Format("Valgte projekt administrator: " + name);
                projectAdmin = userService.FindUserById(Convert.ToInt32(id));
            }
        }

        private void listView_FilesParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_FilesParticipants.SelectedItems.Count == 1)
            {
                ListViewItem.ListViewSubItemCollection rowCollection = listView_FilesParticipants.SelectedItems[0].SubItems;
                string rank = rowCollection[2].Text;
                if (rank.Equals("Member"))
                {
                    button_PromoteDemote.Text = "Promomote";
                }
                else if (rank.Equals("Administrator"))
                {
                    button_PromoteDemote.Text = "Demote";
                }
                button_PromoteDemote.Visible = true;
            }
        }

        private void button_PromoteDemote_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (button_PromoteDemote.Text.Equals("Demote"))
            {
                User user = userService.FindUserById(Convert.ToInt32(listView_ProjectAdmin.SelectedItems[0].SubItems[0].Text));
                if (!user.Username.Equals(""))
                {
                    success = projectService.RemoveProjectAdministratorFromProject(activeProject.Id, user);
                }
                else
                {
                    MessageBox.Show("Fejl");
                }
            }
            else if (button_PromoteDemote.Text.Equals("Promomote"))
            {
                User[] users = userService.FindUserByUsername(listView_ProjectAdmin.SelectedItems[0].Text);
                User user = users.FirstOrDefault();
                if (!user.Username.Equals(""))
                {
                    success = projectService.AddProjectAdministratorToProject(activeProject.Id, user);
                }
                else
                {
                    MessageBox.Show("Fejl");
                }
            }
            if (button_PromoteDemote.Text.Equals("Promote"))
            {
                if (success)
                    MessageBox.Show("Bruger forfremmet til administrator i projektet");
                else
                    MessageBox.Show("Bruger blev ikke forfremmet!");
            }
            else if (button_PromoteDemote.Text.Equals("Demote"))
            {
                if (success)
                    MessageBox.Show("Bruger blev fjernet som administrator i projektet");
                else
                    MessageBox.Show("Bruger blev IKKE fjernet som administrtor i projektet!");
            }
        }
    }
}
