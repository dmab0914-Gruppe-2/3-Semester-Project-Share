using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using ClientApp.FileUploadService;
using ClientApp.ProjectService;
using System.IO;
using ClientApp.ChatService;
using ClientApp.UserService;

namespace ClientApp
{
    public partial class MainWindow : Form
    {
        private static IChatService chatService = new ChatServiceClient();
        private static IUserService userService = new UserServiceClient();
        private static FileUpLoadServiceClient fileClient = new FileUpLoadServiceClient();
        private static IProjectService projectClient = new ProjectServiceClient();
        private Library.File activeFile; //new Library.File();
        private Project project = null;
        private User activeUser = null;
        private int lastMessageId = 0;
        private DateTime LastDate;

        public MainWindow()
        {
            InitializeComponent();
            lblNotImplementedWarning.Visible = false;
            btnUpload.Visible = false;
            btnRefreshFiles.Visible = false;
            btnMulti.Visible = false;
            btnDownload.Visible = false;
            lwFiles.MultiSelect = false;
            listView_Projects.MultiSelect = false;
            this.richTextBox_Filechat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
        }
        private void button_ProjectAdministration_Click(object sender, EventArgs e)
        {
            ProjectAdministration projectAdministration = new ProjectAdministration();
            //projectAdministration.TopLevel = true;
            projectAdministration.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (project.Id != 0)
            {
                UploadDialog ud = new UploadDialog(project);
                ud.ShowDialog();
            }
            else
            {
                MessageBox.Show("select a project please!");
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer_UpdateChat.Start();
            User[] users = userService.FindAllUsers();
            foreach (User user in users)
            {
                comboBox_Users.Items.Add(user.Username);
            }
            //Listview projects setup
            listView_Projects.GridLines = true;
            listView_Projects.View = View.Details;
            listView_Projects.FullRowSelect = true;
            listView_Projects.Columns.Add("ID", 25);
            listView_Projects.Columns.Add("Name", 125);
            listView_Projects.Columns.Add("Description", -2);
            try
            {
                List<Project> projects = projectClient.GetAllProjects().ToList();
                foreach (Project project in projects)
                {
                    string[] row = { project.Id.ToString(), project.Title, project.Description };
                    ListViewItem listViewItem = new ListViewItem(row);
                    listView_Projects.Items.Add(listViewItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl: " + ex);

            }

            //ListView files setup
            lwFiles.GridLines = true;
            lwFiles.View = View.Details;
            lwFiles.FullRowSelect = true;

            lwFiles.Columns.Add("id", 20);
            lwFiles.Columns.Add("File name", 129);
            lwFiles.Columns.Add("Description", -2);

        }

        private void lwFiles_ItemActivate(object sender, EventArgs e)
        {
            if (lwFiles.SelectedItems.Count == 1)
            {
                var fileMetaData = new FileMetaData();
                fileMetaData.FileId = Convert.ToInt32(lwFiles.SelectedItems[0].Text);
                GetFileMessage gfm = new GetFileMessage();
                gfm.Metadata = fileMetaData;
                //Library.File activeFile = fileClient.GetFile(gfm).file;
                activeFile = fileClient.GetFile(gfm).file;
                lblFIleInfo.Text = activeFile.Title;
                txtFileDesc.Text = activeFile.Description;
                btnDownload.Visible = true;
                //TODO Download last 20 messages
                ChatMessage[] messages = chatService.GetLast20MessagesFromFile(activeFile);
                listBox_Filechat.Items.Clear();
                LastDate = DateTime.MinValue;
                UpdateChat(messages);
            }
        }

        private void listView_Projects_ItemActivate(object sender, EventArgs e)
        {
            if (listView_Projects.SelectedItems.Count == 1)
            {

                try
                {
                    lwFiles.Items.Clear();
                    Project activeProject = projectClient.GetProject(Convert.ToInt32(listView_Projects.SelectedItems[0].Text));
                    List<Library.File> files = activeProject.ProjectFiles;
                    foreach (Library.File file in files)
                    {
                        string[] row = { file.Id.ToString(), file.Title, file.Description };
                        ListViewItem lwi = new ListViewItem(row);
                        lwFiles.Items.Add(lwi);
                    }
                    lblFIles.Text = activeProject.Title;
                    project = activeProject;
                    btnUpload.Visible = true;
                    btnRefreshFiles.Visible = true;
                    btnMulti.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fejl: " + ex.Message);
                }


                //try
                //{
                //    List<File> files = fileClient.GetAllFilesForProject(activeProject.Id).ToList();
                //    foreach (File f in files)
                //    {
                //        string[] row = { f.Id.ToString(), f.Title, f.Description };
                //        var lwi = new ListViewItem(row);
                //        lwFiles.Items.Add(lwi);
                //    }
                //}
                //catch (Exception exception)
                //{
                //    MessageBox.Show("Fejl: " + exception);
                //}

            }
            else
            {
                MessageBox.Show("Select a project");
            }
        }

        private void btnRefreshFiles_Click(object sender, EventArgs e)
        {
            if (listView_Projects.SelectedItems.Count == 1)
            {

                try
                {
                    lwFiles.Items.Clear();
                    Project activeProject = projectClient.GetProject(Convert.ToInt32(listView_Projects.SelectedItems[0].Text));
                    List<Library.File> files = activeProject.ProjectFiles;
                    foreach (Library.File file in files)
                    {
                        string[] row = { file.Id.ToString(), file.Title, file.Description };
                        ListViewItem lwi = new ListViewItem(row);
                        lwFiles.Items.Add(lwi);
                    }
                    lblFIles.Text = activeProject.Title;
                    project = activeProject;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fejl: " + ex.Message);
                }
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (project.Id != 0 || project == null)
            {
                MultiUpload mu = new MultiUpload(project);
                mu.ShowDialog();
            }
            else
            {
                MessageBox.Show("select a project please!");
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string filetodownload = @"C:\ProjectShare\Uploads\" + activeFile.Id.ToString() + "." + lblFIleInfo.Text.Substring(lblFIleInfo.Text.LastIndexOf('.') + 1);


           FileMetaData fmd = new FileMetaData();
            fmd.FullLocalPath = filetodownload;
            FileDownloadMessage fdm = new FileDownloadMessage(fmd);

            IssueDownloadRequest(filetodownload, fdm);
        }
        private void IssueDownloadRequest(string localFile, FileDownloadMessage fdm)
        {
            
            try
            {
                var response = fileClient.DownloadFile(fdm);

                if (response != null && response.FileByteStream != null)
                {
                    SaveFile(response.FileByteStream, Path.GetFileName(localFile));
                }


                fileClient.Close();
            }
            catch (Exception e)
            {
                //throw new FileTransferProxyException("Error while downloading the file", e);
                MessageBox.Show("error in downloading the fail \n" + e);
            }
        }

        private void SaveFile(Stream saveFile, string fileName)
        {
            const int bufferSize = 65536; // 64K
            string FILE_SAVE_PATH = @"C:\ProjectShare\downloads\";
            if (!Directory.Exists(FILE_SAVE_PATH))
            {
                Directory.CreateDirectory(FILE_SAVE_PATH);
            }
            using (FileStream outfile = new FileStream(FILE_SAVE_PATH + fileName, FileMode.Create))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead = saveFile.Read(buffer, 0, bufferSize);

                while (bytesRead > 0)
                {
                    outfile.Write(buffer, 0, bytesRead);
                    bytesRead = saveFile.Read(buffer, 0, bufferSize);
                }
            }
        }

        private void button_Chat_send_Click(object sender, EventArgs e)
        {
            lblNotImplementedWarning.Visible = true;
        }

        private void button_SendFilechat_Click(object sender, EventArgs e)
        {
            SendMessageToFile();
        }

        private void SendMessageToFile()
        {
            if (activeFile != null)
            {
                ChatMessage message = new ChatMessage(richTextBox_Filechat.Text, activeUser);
                bool success = chatService.SendMessageToFile(message, activeFile);

                if (success)
                {
                    //listBox_Filechat.Items.Add(DateTime.Now.ToShortTimeString() + " " + message.Sender.Username + ":\n " + message.Message);
                    richTextBox_Filechat.Text = "";
                }
                else
                {
                    listBox_Filechat.Items.Add("ERROR: Message was not sent!");
                }
            }
        }

        private void comboBox_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username = comboBox_Users.SelectedItem.ToString();
            activeUser = userService.FindUserByUsername(username).FirstOrDefault();
        }

        private void UpdateChat(ChatMessage[] messages)
        {
            //listBox_Filechat.Items.Clear();
            
            if (messages.Count() > 0)
            {
                if(messages.First().Time.Date < LastDate)
                {
                    LastDate = messages.First().Time;
                    listBox_Filechat.Items.Add("\t\t *** " + LastDate.Date.ToLongDateString() + " ***");
                }


                
                foreach (ChatMessage message in messages)
                {
                    if (LastDate.Date < message.Time.Date)
                    {
                        LastDate = message.Time.Date;
                        listBox_Filechat.Items.Add("\t\t *** " + message.Time.Date.ToLongDateString() + " ***");
                    }
                    lastMessageId = message.Id;
                    listBox_Filechat.Items.Add(message.Time.ToShortTimeString() + "  " + message.Sender.Username + ": \n" + message.Message);
                }
                listBox_Filechat.SelectedIndex = listBox_Filechat.Items.Count - 1;
                listBox_Filechat.SelectedIndex = -1;
            }

            
            
        }

        private void timer_UpdateChat_Tick(object sender, EventArgs e)
        {
            if (activeFile != null)
            {
                if (lastMessageId == 0) 
                { 
                    ChatMessage[] messages = chatService.GetLast20MessagesFromFile(activeFile);
                    UpdateChat(messages);
                }
                else if (lastMessageId > 0)
                {
                    ChatMessage[] messages = chatService.GetNewMessagesFromFile(activeFile, lastMessageId);
                    UpdateChat(messages);
                }
            }
        }

        private void CheckKeys(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //char 13 is Return (enter) key
            {
                SendMessageToFile();
            }

        }
    }
}
