using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre_Management_System
{
    public partial class ReceptionistHomePage : Form
    {
        public static string username;
        public ReceptionistHomePage(string uname)
        {
            InitializeComponent();
            username = uname;
            
        }

        private void ReceptionistHomePage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection

            //execute command and read from database
            SqlCommand cmd = new SqlCommand("Select name from receptionist where UserID = (select id from Users where username = '" + username + "')", con);
            string name = cmd.ExecuteScalar().ToString();
            
            lblwelcome.Text = "WELCOME, " + name.ToUpper();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
