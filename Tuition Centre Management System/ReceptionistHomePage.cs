using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Tuition_Centre_Management_System
{
    public partial class ReceptionistHomePage : Form
    {
        public static string username;
        public static string userrole;
        public ReceptionistHomePage(string uname, string urole)
        {
            InitializeComponent();
            username = uname;
            userrole = urole;
            
        }
        private void ReceptionistHomePage_Load(object sender, EventArgs e)
        {
            Profile profile1 = new Profile(username, userrole);
            var info = profile1.getProfile();

            txtname.Text = info[0];
            txtcontact.Text = info[1];
            txtemail.Text = info[2];
            txtAddress.Text = info[3];

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            txtname.ReadOnly= false;
            txtcontact.ReadOnly= false;
            txtAddress.ReadOnly= false;
            txtemail.ReadOnly= false;
        }

        private void btnupdateprofile_Click(object sender, EventArgs e)
        {

        }
    }
}
