using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.FileTransfterService;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Library;
using ClientApp.FileCtrService;

namespace ClientApp
{
    public partial class UploadDialog : Form
    {
        static IFile fileService = new FileClient();
        

        private string fullFilePath;
        private string fileToUpload;

        //private string fileName;
        //private int projectId;
        
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
                lblFilePath.Text = openFileDialog1.SafeFileName;
                fullFilePath = openFileDialog1.FileName;
                fileToUpload = Path.GetFileName(fullFilePath);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lblFilePath.Text.Length > 0)
            {
                var client = new FileUpLoadServiceClient();
                try
                {
                    using (Stream fileStream = new FileStream(fullFilePath, FileMode.Open, FileAccess.Read))
                    {
                        var request = new FileUploadMessage();
                        var fileMetaData = new FileMetaData();
                        fileMetaData.FileName = fileToUpload;
                        fileMetaData.FullLocalPath = fullFilePath;
                        fileMetaData.FileType = (DefinedFileTypes)Enum.Parse(typeof(DefinedFileTypes), Path.GetExtension(fileToUpload).ToUpper().Replace(@".", ""));
                        request.Metadata = fileMetaData;
                        request.FileByteStream = fileStream;
                        client.UploadFile(fileMetaData, fileStream);
                        client.Close();
                    }

                    lblFilePath.Text = "";
                    fullFilePath = "";
                    fileToUpload = "";
                }
                catch (IOException)
                {
                    // throw new FileTransferProxyException("Unable to open the file to upload");
                    MessageBox.Show("File error!");
                }
                catch (Exception ex)
                {
                    //throw new FileTransferProxyException(e.Message);
                    MessageBox.Show("Error in upload, please try again. If this continue contact administrator :(");
                }
                finally
                {
                    // this.proxy.AbortProxyIfNeeded(this.service);
                    // MessageBox.Show("This went really bad :( contact administrator for help!");
                }
            }
            else
                MessageBox.Show("Come on man, you need to select a file ;)");
        }
    }
}
