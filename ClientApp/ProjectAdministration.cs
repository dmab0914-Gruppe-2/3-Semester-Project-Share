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
    public partial class ProjectAdministration : Form
    {
        public ProjectAdministration()
        {
            InitializeComponent();
        }

        private void ProjectAdministration_Load(object sender, EventArgs e)
        {
            //ListView load peoperties...
            listView_Projects.GridLines = true;
            listView_Projects.View = View.Details;
            listView_Projects.FullRowSelect = true;
            //ListView columns
            listView_Projects.Columns.Add("Id", 30);
            listView_Projects.Columns.Add("Project", 150);
            listView_Projects.Columns.Add("Description", 200);
            

        }

    }
}
