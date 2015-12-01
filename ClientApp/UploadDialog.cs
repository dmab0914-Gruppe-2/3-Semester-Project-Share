using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.FileUploadService;
using ClientApp.addFileService;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Library;

namespace ClientApp
{
    public partial class UploadDialog : Form
    {
        private string fullFilePath;
        private string fileToUpload;
        private static FileUpLoadServiceClient client = new FileUpLoadServiceClient();
        private static FileServiceClient fac = new FileServiceClient();
        private Project Project;
        public UploadDialog(Project project)
        {
            InitializeComponent();
            this.tTFileName.SetToolTip(lblFileName, "Change file name if needed to project");
            this.tTFileName.SetToolTip(txtFileName, "Change file name if needed to project");
            this.Project = project;
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
                txtFileName.Text = openFileDialog1.SafeFileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lblFilePath.Text.Length > 0)
            {
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
                    AddFile(txtFileName.Text, txtDesc.Text);
                }
                catch (IOException ioException)
                {
                    // throw new FileTransferProxyException("Unable to open the file to upload");
                    MessageBox.Show("File error!" + ioException);
                }
                catch (Exception ex)
                {
                    //throw new FileTransferProxyException(e.Message);
                    MessageBox.Show("Error in upload, please try again. If this continue contact administrator :(" + ex);
                }
                finally
                {
                    lblError.Text = "File uploaded";
                }
            }
            else
                MessageBox.Show("Come on man, you need to select a file ;)");

        }

        private void AddFile(string fileName, string fileDesc)
        {
            if (txtFileName.Text.Length > 0 && txtDesc.Text.Length > 3)
            {
                try
                {
                    fac.AddFile(fileName, fileDesc, Project.Id);
                    
                    lblFilePath.Text = "";
                    txtFileName.Text = "";
                    txtDesc.Text = "";                    
                }
                catch (Exception hest)
                {
                    MessageBox.Show("failed uploading your file to database. Sorry for this :( \n " + hest);
                }
            }
            else
            {
                lblError.Text = "Please recheck all fields Thanks!";
            }
        }
    }
}
