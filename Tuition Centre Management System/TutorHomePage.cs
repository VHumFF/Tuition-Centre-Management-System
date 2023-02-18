using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre_Management_System
{
    public partial class TutorHomePage : Form
    {
        public static string username;
        public static string userrole;
        public TutorHomePage(string uname, string urole)
        {
            InitializeComponent();
            username = uname;
            userrole = urole;
        }

        private void TutorHomePage_Load(object sender, EventArgs e)
        {
            //load user infomation onto profile page
            Profile profile1 = new Profile(username, userrole);
            var info = profile1.getProfile();
            lblwelcome.Text = "Welcome, " + info[0];
            txtname.Text = info[0];
            txtcontact.Text = info[1];
            txtemail.Text = info[2];
            txtAddress.Text = info[3];
            txtlevel.Text = profile1.getLevel();

            //display subject id tutor taught
            Tutor sub_list = new Tutor(username);
            ArrayList subject_list = new ArrayList();
            subject_list = sub_list.get_taught_subject_list();
            foreach(int item in subject_list)
            {
                lstTaught_subject_list.Items.Add(item);
            }

            cmbWeekdays.SelectedIndex = cmbWeekdays.FindString("Monday");

        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            txtcontact.ReadOnly = false;
            txtAddress.ReadOnly= false;
            txtemail.ReadOnly = false;
        }

        private void btnupdateprofile_Click(object sender, EventArgs e)
        {
            Profile update = new Profile(username, userrole, this.txtcontact.Text, this.txtAddress.Text, this.txtemail.Text);
            update.updateProfile();
            txtcontact.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtemail.ReadOnly = true;
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            Profile contact = new Profile(this.txtcontact.Text);
            if (contact.IsContactValid())
            {
                lblcontacterror.Text = "";
                if (lbladdresserror.Text == "Invalid Address" || lblemailerror.Text == "Invalid Email Address")
                    btnupdateprofile.Enabled = false;
                else
                    btnupdateprofile.Enabled = true;
            }
            else
            {
                lblcontacterror.Text = "Invalid Contact Number";
                btnupdateprofile.Enabled = false;
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            Profile email = new Profile(this.txtemail.Text);
            if (email.IsEmailValid())
            {
                lblemailerror.Text = "";
                if (lbladdresserror.Text == "Invalid Address" || lblcontacterror.Text == "Invalid Contact Number")
                    btnupdateprofile.Enabled = false;
                else
                    btnupdateprofile.Enabled = true;
            }
            else
            {
                lblemailerror.Text = "Invalid Email Address";
                btnupdateprofile.Enabled = false;
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            Profile address = new Profile(this.txtAddress.Text);
            if (address.IsStringValid())
            {
                lbladdresserror.Text = "";
                if (lblemailerror.Text == "Invalid Email Address" || lblcontacterror.Text == "Invalid Contact Number")
                    btnupdateprofile.Enabled = false;
                else
                    btnupdateprofile.Enabled = true;
            }
            else
            {
                lbladdresserror.Text = "Invalid Address";
                btnupdateprofile.Enabled = false;
            }
        }

        private void lblcpass_Click(object sender, EventArgs e)
        {
            //open change password window
            changePassword cp = new changePassword(username);
            cp.ShowDialog();
        }

        private void lstTaught_subject_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subject_id = lstTaught_subject_list.GetItemText(lstTaught_subject_list.SelectedItem);

            if(lstTaught_subject_list.SelectedItems.Count > 0)
            {
                Tutor obj = new Tutor(Convert.ToInt32(subject_id));
                lblsubject_name_selected.Text = obj.get_subject_name();
                btnCreate.Enabled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(dtpStart_Time.Value > dtpEnd_Time.Value)
            {
                MessageBox.Show("Start Time must be earlier than End Time");
            }
            else if(dtpStart_Time.Value == dtpEnd_Time.Value)
            {
                MessageBox.Show("End Time should be greater than Start Time");
            }
            else if((dtpEnd_Time.Value - dtpStart_Time.Value).TotalHours > 2)
            {
                MessageBox.Show("Class must not exceed 2 hours");
            }
            else if ((dtpEnd_Time.Value - dtpStart_Time.Value).TotalHours < 0.5)
            {
                MessageBox.Show("Class must not less than 30 minutes");
            }
            else
            {
                DialogResult create_class = MessageBox.Show("Class Information\n\n\nSubject Name : "+lblsubject_name_selected.Text+"\n\nStart Time : "+dtpStart_Time.Value.ToString("hh mm tt")+
                    "\n\nEnd Time : "+dtpEnd_Time.Value.ToString("hh mm tt")+"\n\nWeekday : "+cmbWeekdays.Text, "Create Class Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(create_class == DialogResult.Yes)
                {

                }
            }

        }
    }
}
