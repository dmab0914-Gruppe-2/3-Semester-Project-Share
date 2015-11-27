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

            lwFiles.Columns.Add("File name", 149);
            lwFiles.Columns.Add("Description", -2);
            try
            {
                List<File> files = client.GetAllFilesForProject(1).ToList();
                foreach (File f in files)
                {
                    string[] row = { f.Title, f.Description };
                    var lwi = new ListViewItem(row);
                    lwFiles.Items.Add(lwi);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hest :" + ex);
            }
        }
    }
}
