using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Centre_Management_System
{
    public partial class AdminHomePage : Form
    {

        public static string username;
        public static string userrole;
        public AdminHomePage(string uname, string urole)
        {
            InitializeComponent();
            username = uname;
            userrole = urole;
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            Profile profile1 = new Profile(username, userrole);
            var info = profile1.getProfile();
            lblwelcome.Text = "Welcome, " + info[0];
            txtname.Text = info[0];
            txtcontact.Text = info[1];
            txtemail.Text = info[2];
            txtAddress.Text = info[3];



            cmbTutorLevel.Text = "Form 1";

            admin obj = new admin();
            ArrayList tutorlist = new ArrayList();
            ArrayList receplist = new ArrayList();
            tutorlist = obj.getTutorIDList();
            receplist = obj.getRecepIDList();
            foreach (int i in tutorlist)
            {
                lstTutorID.Items.Add(i);
            }
            foreach (int i in receplist)
            {
                lstRecepID.Items.Add(i);
            }

        }

        private void txtBoxtutEmail_TextChanged(object sender, EventArgs e)
        {
            Profile email = new Profile(this.txtTutorEmail.Text);
            if (email.IsEmailValid())
            {
                lblEmail_error_message.Text = "";
                if (lblAddress_error_messsage.Text == "Invalid Address" || lblContact_error_message.Text == "Invalid Contact Number"
                    || lblName_error_message.Text == "Invalid Tutor name" || lblUsername_error_message.Text == "Invalid Username")
                {
                    btnRegisterTutor.Enabled = false;
                }
                else if (txtTutorContact.Text == "" || txtTutorAddress.Text == ""
                    || txtTutorName.Text == "" || txtTutorUsername.Text == "")
                {
                    btnRegisterTutor.Enabled = false;
                }
                else
                {
                    btnRegisterTutor.Enabled = true;
                }
            }
            else
            {
                lblEmail_error_message.Text = "Invalid Email Address";
                btnRegisterTutor.Enabled = false;
            }
        }

        private void txtTutorAddress_TextChanged(object sender, EventArgs e)
        {
            //check whether user user have enter a valid data
            Profile address = new Profile(this.txtTutorAddress.Text);
            if (address.IsStringValid())
            {
                lblAddress_error_messsage.Text = "";
                if (lblContact_error_message.Text == "Invalid Contact Number" || lblEmail_error_message.Text == "Invalid Email Address"
                    || lblName_error_message.Text == "Invalid Tutor name" || lblUsername_error_message.Text == "Invalid Username")
                {
                    btnRegisterTutor.Enabled = false;
                }
                else if (txtTutorContact.Text == "" || txtTutorEmail.Text == ""
                    || txtTutorName.Text == "" || txtTutorUsername.Text == "")
                {
                    btnRegisterTutor.Enabled = false;
                }
                else
                {
                    btnRegisterTutor.Enabled = true;
                }
            }
            else
            {
                lblAddress_error_messsage.Text = "Invalid Address";
                btnRegisterTutor.Enabled = false;
            }
        }

        private void txtTutorUsername_TextChanged(object sender, EventArgs e)
        {
            Profile username = new Profile(this.txtTutorUsername.Text);
            if (username.IsStringValid())
            {
                lblUsername_error_message.Text = "";
                if (lblContact_error_message.Text == "Invalid Contact Number" || lblEmail_error_message.Text == "Invalid Email Address"
                    || lblName_error_message.Text == "Invalid Tutor name" || lblAddress_error_messsage.Text == "Invalid Address")
                {
                    btnRegisterTutor.Enabled = false;
                }
                else if (txtTutorContact.Text == "" || txtTutorEmail.Text == ""
                    || txtTutorName.Text == "" || txtTutorAddress.Text == "")
                {
                    btnRegisterTutor.Enabled = false;
                }
                else
                {
                    btnRegisterTutor.Enabled = true;
                }
            }
            else if (txtTutorUsername.Text.Length == 0)
            {
                lblUsername_error_message.Text = "Invalid Username";
                btnRegisterTutor.Enabled = false;
            }
            else
            {
                lblUsername_error_message.Text = "Invalid Username";
                btnRegisterTutor.Enabled = false;
            }
        }

        private void txtTutorName_TextChanged(object sender, EventArgs e)
        {
            Profile name = new Profile(this.txtTutorName.Text);
            if (name.IsStringValid())
            {
                lblName_error_message.Text = "";
                if (lblContact_error_message.Text == "Invalid Contact Number" || lblEmail_error_message.Text == "Invalid Email Address"
                    || lblUsername_error_message.Text == "Invalid Username" || lblAddress_error_messsage.Text == "Invalid Address")
                {

                    btnRegisterTutor.Enabled = false;
                }
                else if (txtTutorContact.Text == "" || txtTutorEmail.Text == ""
                    || txtTutorUsername.Text == "" || txtTutorAddress.Text == "")
                {

                    btnRegisterTutor.Enabled = false;
                }
                else
                {

                    btnRegisterTutor.Enabled = true;
                }
            }
            else if (txtTutorName.Text.Length <= 0)
            {
                lblName_error_message.Text = "Invalid Tutor name";
                btnRegisterTutor.Enabled = false;
            }
            else
            {
                lblName_error_message.Text = "Invalid Tutor name";
                btnRegisterTutor.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnRegisterTutor.Enabled = false;
            txtTutorUsername.Enabled = true;
            txtTutorName.Enabled = true;
            txtTutorContact.Enabled = true;
            txtTutorEmail.Enabled = true;
            txtTutorAddress.Enabled = true;
            cmbTutorLevel.Enabled = true;
            btnDeleteTutor.Enabled = false;


            txtTutorName.Text = String.Empty;
            txtTutorContact.Text = String.Empty;
            txtTutorEmail.Text = String.Empty;
            txtTutorAddress.Text = String.Empty;
            txtTutorUsername.Text = String.Empty;
            cmbTutorLevel.SelectedIndex = cmbTutorLevel.FindString("Form 1");
            lblName_error_message.Text = "";
            lblUsername_error_message.Text = "";
            lblContact_error_message.Text = "";
            lblEmail_error_message.Text = "";
            lblAddress_error_messsage.Text = "";
        }

        private void btnRegisterTutor_Click(object sender, EventArgs e)
        {

            DialogResult registerStudent = MessageBox.Show("Tutor Personal Information\n\n\nUsername: " + txtTutorUsername.Text + "\n\nName: " + txtTutorName.Text +
                "\n\nContact: " + txtTutorContact.Text + "\n\nEmail: " + txtTutorEmail.Text + "\n\nAddress: " + txtTutorAddress.Text + "\n\nLevel: " + cmbTutorLevel.Text +
                "\n\n\nComfirm Tutor Information", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (registerStudent == DialogResult.Yes)
            {
                //if user click yes, register user
                User UserExist = new User(this.txtTutorUsername.Text);
                int userid = UserExist.checkUsername("tutor");
                if (userid == -1)
                {
                    //user name exist, display error message
                    MessageBox.Show("Username Exist. Please try with another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //register tutor
                    admin obj = new admin(userid, this.txtTutorName.Text, this.txtTutorContact.Text, this.txtTutorEmail.Text, this.txtTutorAddress.Text, this.cmbTutorLevel.Text);
                    obj.register_tutor();
                    MessageBox.Show("Tutor has been successfully registered.", "Registration Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reset textbox and combobox
                    txtTutorName.Text = String.Empty;
                    txtTutorContact.Text = String.Empty;
                    txtTutorEmail.Text = String.Empty;
                    txtTutorAddress.Text = String.Empty;
                    txtTutorUsername.Text = String.Empty;
                    cmbTutorLevel.SelectedIndex = cmbTutorLevel.FindString("Form 1");
                    lblName_error_message.Text = "";
                    lblUsername_error_message.Text = "";
                    lblContact_error_message.Text = "";
                    lblEmail_error_message.Text = "";
                    lblAddress_error_messsage.Text = "";

                }

            }
        }

        private void lstTutorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tutorid = lstTutorID.GetItemText(lstTutorID.SelectedItem);


            if (lstTutorID.SelectedItems.Count > 0)
            {
                admin obj = new admin(Convert.ToInt32(tutorid));
                var tutor_info = obj.getTutorInfo();

                txtTutorUsername.Enabled = false;
                txtTutorName.Enabled =false;
                txtTutorContact.Enabled = false;
                txtTutorEmail.Enabled = false;
                txtTutorAddress.Enabled = false;
                cmbTutorLevel.Enabled = false;
                btnRegisterTutor.Enabled = false;
                btnDeleteTutor.Enabled = true;

                txtTutorUsername.Text = "";
                txtTutorName.Text = tutor_info.Item1;
                txtTutorContact.Text = tutor_info.Item2;
                txtTutorEmail.Text = tutor_info.Item3;
                txtTutorAddress.Text = tutor_info.Item4;
                cmbTutorLevel.Text = tutor_info.Item5;
                lblUsername_error_message.Text = "";
                
            }

            
        }

        private void txtTutorContact_TextChanged(object sender, EventArgs e)
        {
            Profile contact = new Profile(this.txtTutorContact.Text);
            if (contact.IsContactValid())
            {
                lblContact_error_message.Text = "";
                if (lblAddress_error_messsage.Text == "Invalid Address" || lblEmail_error_message.Text == "Invalid Email Address"
                    || lblName_error_message.Text == "Invalid Tutor name" || lblUsername_error_message.Text == "Invalid Username")
                {
                    btnRegisterTutor.Enabled = false;
                }
                else if (txtTutorEmail.Text == "" || txtTutorAddress.Text == ""
                    || txtTutorName.Text == "" || txtTutorUsername.Text == "")
                {
                    btnRegisterTutor.Enabled = false;
                }
                else
                {
                    btnRegisterTutor.Enabled = true;
                }
            }
            else
            {
                lblContact_error_message.Text = "Invalid Contact Number";
                btnRegisterTutor.Enabled = false;
            }
        }

        private void btnDeleteTutor_Click(object sender, EventArgs e)
        {
            string tutorid = lstTutorID.GetItemText(lstTutorID.SelectedItem);


            if (lstTutorID.SelectedItems.Count > 0)
            {
                DialogResult DeleteTutor = MessageBox.Show("Are you sure you want to delete the selected tutor", "Tutor Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DeleteTutor == DialogResult.Yes)
                {
                    admin obj = new admin(Convert.ToInt32(tutorid));
                    obj.deleteTutor();
                    MessageBox.Show("Selected tutor account have been deleted", "Tutot Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtTutorName.Text = String.Empty;
                    txtTutorContact.Text = String.Empty;
                    txtTutorEmail.Text = String.Empty;
                    txtTutorAddress.Text = String.Empty;
                    txtTutorUsername.Text = String.Empty;
                    cmbTutorLevel.SelectedIndex = cmbTutorLevel.FindString("Form 1");
                    lblName_error_message.Text = "";
                    lblUsername_error_message.Text = "";
                    lblContact_error_message.Text = "";
                    lblEmail_error_message.Text = "";
                    lblAddress_error_messsage.Text = "";
                    btnDeleteTutor.Enabled = false;
                    lstTutorID.Items.Clear();


                    admin obj2 = new admin();
                    ArrayList tutorlist = new ArrayList();
                    tutorlist = obj2.getTutorIDList();
                    foreach (int i in tutorlist)
                    {
                        lstTutorID.Items.Add(i);
                    }

                }
            }
        }

        private void txtRecepUsername_TextChanged(object sender, EventArgs e)
        {
            Profile username = new Profile(this.txtRecepUsername.Text);
            if (username.IsStringValid())
            {
                lblUsername_error_message2.Text = "";
                if (lblContact_error_message2.Text == "Invalid Contact Number" || lblEmail_error_message2.Text == "Invalid Email Address"
                    || lblName_error_message2.Text == "Invalid Receptionist name" || lblAddress_error_message2.Text == "Invalid Address")
                {
                    btnRegisterRecep.Enabled = false;
                }
                else if (txtRecepContact.Text == "" || txtRecepEmail.Text == ""
                    || txtRecepName.Text == "" || txtRecepAddress.Text == "")
                {
                    btnRegisterRecep.Enabled = false;
                }
                else
                {
                    btnRegisterRecep.Enabled = true;
                }
            }
            else if (txtRecepUsername.Text.Length == 0)
            {
                lblUsername_error_message2.Text = "Invalid Username";
                btnRegisterRecep.Enabled = false;
            }
            else
            {
                lblUsername_error_message2.Text = "Invalid Username";
                btnRegisterRecep.Enabled = false;
            }
        }

        private void txtRecepName_TextChanged(object sender, EventArgs e)
        {
            Profile name = new Profile(this.txtRecepName.Text);
            if (name.IsStringValid())
            {
                lblName_error_message2.Text = "";
                if (lblContact_error_message2.Text == "Invalid Contact Number" || lblEmail_error_message2.Text == "Invalid Email Address"
                    || lblUsername_error_message2.Text == "Invalid Username" || lblAddress_error_message2.Text == "Invalid Address")
                {

                    btnRegisterRecep.Enabled = false;
                }
                else if (txtRecepContact.Text == "" || txtRecepEmail.Text == ""
                    || txtRecepUsername.Text == "" || txtRecepAddress.Text == "")
                {

                    btnRegisterRecep.Enabled = false;
                }
                else
                {

                    btnRegisterRecep.Enabled = true;
                }
            }
            else if (txtRecepName.Text.Length <= 0)
            {
                lblName_error_message2.Text = "Invalid Receptionist name";
                btnRegisterRecep.Enabled = false;
            }
            else
            {
                lblName_error_message2.Text = "Invalid Receptionist name";
                btnRegisterRecep.Enabled = false;
            }
        }

        private void txtRecepContact_TextChanged(object sender, EventArgs e)
        {
            Profile contact = new Profile(this.txtRecepContact.Text);
            if (contact.IsContactValid())
            {
                lblContact_error_message2.Text = "";
                if (lblAddress_error_message2.Text == "Invalid Address" || lblEmail_error_message2.Text == "Invalid Email Address"
                    || lblName_error_message2.Text == "Invalid Receptionist name" || lblUsername_error_message2.Text == "Invalid Username")
                {
                    btnRegisterRecep.Enabled = false;
                }
                else if (txtRecepEmail.Text == "" || txtRecepAddress.Text == ""
                    || txtRecepName.Text == "" || txtRecepUsername.Text == "")
                {
                    btnRegisterRecep.Enabled = false;
                }
                else
                {
                    btnRegisterRecep.Enabled = true;
                }
            }
            else
            {
                lblContact_error_message2.Text = "Invalid Contact Number";
                btnRegisterRecep.Enabled = false;
            }
        }

        private void txtRecepEmail_TextChanged(object sender, EventArgs e)
        {
            Profile email = new Profile(this.txtRecepEmail.Text);
            if (email.IsEmailValid())
            {
                lblEmail_error_message2.Text = "";
                if (lblAddress_error_message2.Text == "Invalid Address" || lblContact_error_message2.Text == "Invalid Contact Number"
                    || lblName_error_message2.Text == "Invalid Receptionist name" || lblUsername_error_message2.Text == "Invalid Username")
                {
                    btnRegisterRecep.Enabled = false;
                }
                else if (txtRecepContact.Text == "" || txtRecepAddress.Text == ""
                    || txtRecepName.Text == "" || txtRecepUsername.Text == "")
                {
                    btnRegisterRecep.Enabled = false;
                }
                else
                {
                    btnRegisterRecep.Enabled = true;
                }
            }
            else
            {
                lblEmail_error_message2.Text = "Invalid Email Address";
                btnRegisterRecep.Enabled = false;
            }
        }

        private void txtRecepAddress_TextChanged(object sender, EventArgs e)
        {
            //check whether user user have enter a valid data
            Profile address = new Profile(this.txtRecepAddress.Text);
            if (address.IsStringValid())
            {
                lblAddress_error_message2.Text = "";
                if (lblContact_error_message2.Text == "Invalid Contact Number" || lblEmail_error_message2.Text == "Invalid Email Address"
                    || lblName_error_message2.Text == "Invalid Receptionist name" || lblUsername_error_message2.Text == "Invalid Username")
                {
                    btnRegisterRecep.Enabled = false;
                }
                else if (txtRecepContact.Text == "" || txtRecepEmail.Text == ""
                    || txtRecepName.Text == "" || txtRecepUsername.Text == "")
                {
                    btnRegisterRecep.Enabled = false;
                }
                else
                {
                    btnRegisterRecep.Enabled = true;
                }
            }
            else
            {
                lblAddress_error_message2.Text = "Invalid Address";
                btnRegisterRecep.Enabled = false;
            }
        }

        private void lstRecepID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string recepid = lstRecepID.GetItemText(lstRecepID.SelectedItem);


            if (lstRecepID.SelectedItems.Count > 0)
            {
                admin obj = new admin(Convert.ToInt32(recepid));
                var recep_info = obj.getRecepInfo();

                txtRecepUsername.Enabled = false;
                txtRecepName.Enabled = false;
                txtRecepContact.Enabled = false;
                txtRecepEmail.Enabled = false;
                txtRecepAddress.Enabled = false;
                btnRegisterRecep.Enabled = false;
                btnDelete2.Enabled = true;

                txtRecepUsername.Text = "";
                txtRecepName.Text = recep_info.Item1;
                txtRecepContact.Text = recep_info.Item2;
                txtRecepEmail.Text = recep_info.Item3;
                txtRecepAddress.Text = recep_info.Item4;
                lblUsername_error_message2.Text = "";


            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            btnRegisterRecep.Enabled = false;
            txtRecepUsername.Enabled = true;
            txtRecepName.Enabled = true;
            txtRecepContact.Enabled = true;
            txtRecepEmail.Enabled = true;
            txtRecepAddress.Enabled = true;
            btnDelete2.Enabled = false;


            txtRecepName.Text = String.Empty;
            txtRecepContact.Text = String.Empty;
            txtRecepEmail.Text = String.Empty;
            txtRecepAddress.Text = String.Empty;
            txtRecepUsername.Text = String.Empty;

            lblName_error_message2.Text = "";
            lblUsername_error_message2.Text = "";
            lblContact_error_message2.Text = "";
            lblEmail_error_message2.Text = "";
            lblAddress_error_message2.Text = "";
        }

        private void btnRegisterRecep_Click(object sender, EventArgs e)
        {
            DialogResult registerRecep = MessageBox.Show("Receptionist Personal Information\n\n\nUsername: " + txtRecepUsername.Text + "\n\nName: " + txtRecepName.Text +
                 "\n\nContact: " + txtRecepContact.Text + "\n\nEmail: " + txtRecepEmail.Text + "\n\nAddress: " + txtRecepAddress.Text + 
                 "\n\n\nComfirm Receptionist Information", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (registerRecep == DialogResult.Yes)
            {
                //if user click yes, register user
                User UserExist = new User(this.txtRecepUsername.Text);
                int userid = UserExist.checkUsername("receptionist");
                if (userid == -1)
                {
                    //user name exist, display error message
                    MessageBox.Show("Username Exist. Please try with another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //register receptionist
                    admin obj = new admin(userid, this.txtRecepName.Text, this.txtRecepContact.Text, this.txtRecepEmail.Text, this.txtRecepAddress.Text);
                    obj.register_recep();
                    MessageBox.Show("Tutor has been successfully registered.", "Registration Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reset textbox and combobox
                    txtRecepName.Text = String.Empty;
                    txtRecepContact.Text = String.Empty;
                    txtRecepEmail.Text = String.Empty;
                    txtRecepAddress.Text = String.Empty;
                    txtRecepUsername.Text = String.Empty;

                    lblName_error_message2.Text = "";
                    lblUsername_error_message2.Text = "";
                    lblContact_error_message2.Text = "";
                    lblEmail_error_message2.Text = "";
                    lblAddress_error_message2.Text = "";

                }

            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            string recepid = lstRecepID.GetItemText(lstRecepID.SelectedItem);


            if (lstRecepID.SelectedItems.Count > 0)
            {
                DialogResult DeleteRecep = MessageBox.Show("Are you sure you want to delete the selected receptionist", "Receptionist Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DeleteRecep == DialogResult.Yes)
                {
                    admin obj = new admin(Convert.ToInt32(recepid));
                    obj.deleteRecep();
                    MessageBox.Show("Selected receptionist account have been deleted", "Receptionist Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtRecepName.Text = String.Empty;
                    txtRecepContact.Text = String.Empty;
                    txtRecepEmail.Text = String.Empty;
                    txtRecepAddress.Text = String.Empty;
                    txtRecepUsername.Text = String.Empty;

                    lblName_error_message2.Text = "";
                    lblUsername_error_message2.Text = "";
                    lblContact_error_message2.Text = "";
                    lblEmail_error_message2.Text = "";
                    lblAddress_error_message2.Text = "";
                    btnDelete2.Enabled = false;
                    lstRecepID.Items.Clear();


                    admin obj2 = new admin();
                    ArrayList receplist = new ArrayList();
                    receplist = obj2.getRecepIDList();
                    foreach (int i in receplist)
                    {
                        lstRecepID.Items.Add(i);
                    }

                }
            }
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            dgvIncomeReport.Rows.Clear();
            string d = dtpMonthYear.Value.ToString("MM-yyyy");
            DateTime date = DateTime.ParseExact(d, "MM-yyyy", CultureInfo.InvariantCulture);

            int month = date.Month;
            int year = date.Year;

            admin obj = new admin(month, year);
            ArrayList receiptID = new ArrayList();
            receiptID = obj.getreceiptid();

            
            foreach (int i in receiptID)
            {
                admin obj2 = new admin(i);
                var income_report = obj2.getIncomeReport();
                dgvIncomeReport.Rows.Add(income_report.Item1, income_report.Item2);
            }

            int sum = 0;
            for (int i = 0; i < dgvIncomeReport.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvIncomeReport.Rows[i].Cells[1].Value);
            }
            lblTotal.Text = "Income Total : RM"+sum.ToString();


        }

        private void dtpMonthYear_ValueChanged(object sender, EventArgs e)
        {
            dgvIncomeReport.Rows.Clear();
            lblTotal.Text = "Income Total : ";
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            txtcontact.ReadOnly = false;
            txtAddress.ReadOnly = false;
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
            changePassword cp = new changePassword(username);
            cp.ShowDialog();
        }
    }
}
