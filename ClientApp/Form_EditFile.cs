using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form_EditFile : Form
    {
        string workingDir;
        FileInfo currentFileInfo;
        public Form_EditFile()
        {
            InitializeComponent();
        }

        private void Form_EditFile_Load(object sender, EventArgs e)
        {
            string username = Environment.UserName;
            string currentDir = Environment.CurrentDirectory;
            workingDir = currentDir + "\\WorkingDirectory";
            if (!System.IO.Directory.Exists(workingDir))
            {
                System.IO.Directory.CreateDirectory(workingDir);
            }
            label_Username.Text = string.Format("Greetings {0}, Welcome back!", username);

            DirectoryInfo directory = new DirectoryInfo(workingDir);
            foreach (FileInfo file in directory.GetFiles())
            {
                listBox_Files.Items.Add(file.Name);
            }
            label_CurrentDirectory.Text = string.Format("Current Directory: {0}", currentDir);
            label_workingDirectory.Text = string.Format("Working Directory: {0}", workingDir);

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            string file = listBox_Files.SelectedItem.ToString();
            //int fileInfoIndex = listBox_Files.SelectedIndex;
            DirectoryInfo directory = new DirectoryInfo(workingDir);
            currentFileInfo = directory.GetFiles().FirstOrDefault(x => x.Name.Equals(file));
            if(currentFileInfo.Exists)
                MessageBox.Show(currentFileInfo.FullName);


            //label_CurrentDirectory.Text = string.Format("Current file: ", obj.ToString());
        }
    }
}
