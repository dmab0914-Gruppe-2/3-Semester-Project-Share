using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientApp.UserService;
using Library;

namespace ClientApp
{
    public partial class Form_FindUsers : Form
    {
        public Form_FindUsers()
        {
            InitializeComponent();
        }

        private void button_FindUser_Click(object sender, EventArgs e)
        {
            bool multiParameter = false;

        }

        private void Form_FindUsers_Load(object sender, EventArgs e)
        {
            UserService.IUserService userService = new UserServiceClient();
            //Listview settings
            listView_Users.GridLines = true;
            listView_Users.FullRowSelect = true;
            listView_Users.View = View.Details;

            //Listview columns
            listView_Users.Columns.Add("Id", 25);
            listView_Users.Columns.Add("Username", 150);
            listView_Users.Columns.Add("Email", 150);

            User[] allUsers = userService.FindAllUsers();
            foreach (User user in allUsers)
            {
                string[] row = {user.Id.ToString(), user.Username, user.Email};
                ListViewItem lwi = new ListViewItem(row);
                listView_Users.Items.Add(lwi);
            }
        }
    }
}
