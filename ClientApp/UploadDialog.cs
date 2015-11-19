using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.FileCtrService;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Library;

namespace ClientApp
{
    public partial class UploadDialog : Form
    {
        static IFile fileService = new FileClient();

        private string fileName;
        private int projectId;

        
        public UploadDialog()
        {
            InitializeComponent();
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lblFilePath.Text.Length > 0)
            {
                FilePrepare filePreare = new FilePrepare();
                filePreare.FileName = openFileDialog1.SafeFileName;

                fileService.Prepare(filePreare);

                FileTransfer ft = new FileTransfer();
                ft.SendFile(openFileDialog1.FileName, filePreare.serverport);
            }
        }
    }
}
