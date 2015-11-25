using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadDialog ud = new UploadDialog();
            ud.ShowDialog();
        }

        private void button_ProjectAdministration_Click(object sender, EventArgs e)
        {
            ProjectAdministration projectAdministration = new ProjectAdministration();
            projectAdministration.TopLevel = true;
            projectAdministration.ShowDialog();
        }
    }
}
