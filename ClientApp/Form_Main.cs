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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_EditFile_Click(object sender, EventArgs e)
        {
            Form_EditFile editfile = new Form_EditFile();
            editfile.Enabled = true;
            editfile.Visible = true;
        }
    }
}
