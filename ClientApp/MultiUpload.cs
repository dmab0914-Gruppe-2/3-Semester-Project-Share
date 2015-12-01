using Library;
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

namespace ClientApp
{
    public partial class MultiUpload : Form
    {
        private static FileUpLoadServiceClient client = new FileUpLoadServiceClient();
        private static FileServiceClient fac = new FileServiceClient();
        private Project Project;
        private List<string> fullFilePathList = new List<string>();
        private List<string> fileToUploadList = new List<string>();
        public MultiUpload(Project project)
        {
            InitializeComponent();
            this.Project = project;
            openFileDialog1.Multiselect = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView1.ReadOnly = false;
            btnUpload.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (fullFilePathList != null && fileToUploadList != null)
            {

                //try
                //{
                    foreach (string fullFilePath in fullFilePathList)
                    {
                        //using (Stream fileStream = new FileStream(fullFilePath, FileMode.Open, FileAccess.Read))
                        //{
                        //    var request = new FileUploadMessage();
                        //    var fileMetaData = new FileMetaData();
                        //    fileMetaData.FileName = fileToUploadList[i];
                        //    fileMetaData.FullLocalPath = fullFilePath;
                        //    fileMetaData.FileType = (DefinedFileTypes)Enum.Parse(typeof(DefinedFileTypes), Path.GetExtension(fileToUploadList[i]).ToUpper().Replace(@".", ""));
                        //    request.Metadata = fileMetaData;
                        //    request.FileByteStream = fileStream;
                        //    client.UploadFile(fileMetaData, fileStream);
                            
                        //}
                       // AddFiles(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString());
                        
                        i++;
                    }
                    AddFiles();
                   // client.Close();
                //}
                //catch (IOException ioException)
                //{
                //    // throw new FileTransferProxyException("Unable to open the file to upload");
                //    MessageBox.Show("File error!" + ioException);
                //}
                //catch (Exception ex)
                //{
                //    //throw new FileTransferProxyException(e.Message);
                //    MessageBox.Show("Error in upload, please try again. If this continue contact administrator :(" + ex);
                //}
                //finally
                //{
                //    lblError.Text = "File uploaded";
                //}

            }

        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                btnUpload.Enabled = true;
                lblError.Text = "";
                //fileToUploadList = null;
                //fileToUploadList = null;                
                #region dataGridView stuff
                List<String> files = openFileDialog1.SafeFileNames.ToList();
                List<Library.File> myFiles = new List<Library.File>();
                foreach (string f in files)
                {
                    Library.File file = new Library.File(f, "", Project);
                    myFiles.Add(file);
                }
                dataGridView1.DataSource = myFiles;
                dataGridView1.Columns.Remove("id");
                dataGridView1.Columns.Remove("VersionNr");
                dataGridView1.Columns.Remove("FileLock");
                dataGridView1.Columns.Remove("FileLockTime");
                dataGridView1.Columns.Remove("Project");
                dataGridView1.AutoResizeColumns();
                #endregion
                foreach (string filepath in openFileDialog1.FileNames)
                {
                    fullFilePathList.Add(filepath);
                    fileToUploadList.Add(Path.GetFileName(filepath));
                }

            }
        }

        private void AddFiles()
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                fac.AddFile(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), Project);
            }
            btnUpload.Enabled = false;
            lblError.Text = "Upload done";
        }

    }
}
