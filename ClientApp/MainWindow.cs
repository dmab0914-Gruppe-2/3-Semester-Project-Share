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

namespace ClientApp
{
    public partial class MainWindow : Form
    {
        private static FileUpLoadServiceClient client = new FileUpLoadServiceClient();
        //private File activeFile = new File();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_ProjectAdministration_Click(object sender, EventArgs e)
        {
            ProjectAdministration projectAdministration = new ProjectAdministration();
            projectAdministration.TopLevel = true;
            projectAdministration.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadDialog ud = new UploadDialog();
            ud.ShowDialog();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lwFiles.GridLines = true;
            lwFiles.View = View.Details;
            lwFiles.FullRowSelect = true;

            lwFiles.Columns.Add("id", 20);
            lwFiles.Columns.Add("File name", 129);
            lwFiles.Columns.Add("Description", -2);
            try
            {
                List<File> files = client.GetAllFilesForProject(1).ToList();
                foreach (File f in files)
                {
                    string[] row = { f.Id.ToString(), f.Title, f.Description };
                    var lwi = new ListViewItem(row);
                    lwFiles.Items.Add(lwi);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hest :" + ex);
            }
        }

        private void lwFiles_ItemActivate(object sender, EventArgs e)
        {
            if (lwFiles.SelectedItems.Count == 1)
            {
                File activeFile = client.GetFile(Convert.ToInt32(lwFiles.SelectedItems[0].Text));
                lblFIleInfo.Text = activeFile.Title;
                txtFileDesc.Text = activeFile.Description;
            }
        }
    }
}
