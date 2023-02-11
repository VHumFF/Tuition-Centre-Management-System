﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //load user infomation onto profile page
            Profile profile1 = new Profile(username, userrole);
            var info = profile1.getProfile();
            lblwelcome.Text = "Welcome, " + info[0];
            txtname.Text = info[0];
            txtcontact.Text = info[1];
            txtemail.Text = info[2];
            txtAddress.Text = info[3];


            //set student level combobox default value as "Form 1"
            if (cmbStudent_Level.SelectedIndex == -1)
                cmbStudent_Level.SelectedIndex = cmbStudent_Level.FindString("Form 1");

        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            //make the textbox editable
            txtcontact.ReadOnly= false;
            txtAddress.ReadOnly= false;
            txtemail.ReadOnly= false;
        }

        private void btnupdateprofile_Click(object sender, EventArgs e)
        {
            //update user profile
            Profile update = new Profile(username, userrole, this.txtcontact.Text, this.txtAddress.Text, this.txtemail.Text);
            update.updateProfile();
            txtcontact.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtemail.ReadOnly = true;
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            //check whether the contact user enter is valid
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
            //check whether the email user enter is valid
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
            //check whether the address user enter is valid
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

        private void txtStudent_Contact_TextChanged(object sender, EventArgs e)
        {
            //check whether user user have enter a valid data
            Profile contact = new Profile(this.txtStudent_Contact.Text);
            if (contact.IsContactValid())
            {
                lblStudent_Contact_error.Text = "";
                if (lblStudent_Address_error.Text == "Invalid Address" || lblStudent_Email_error.Text == "Invalid Email Address" 
                    || lblStudent_Name_error.Text == "Invalid Student name" || lblStudent_Username_error.Text == "Invalid Username")
                {
                    btnRegister_Student.Enabled = false;
                }           
                else if (txtStudent_Email.Text == "" || txtStudent_Address.Text == ""
                    || txtStudent_Name.Text == "" || txtStudent_Username.Text == "")
                {
                    btnRegister_Student.Enabled = false;
                }
                else
                {
                    btnRegister_Student.Enabled = true;
                }
            }
            else
            {
                lblStudent_Contact_error.Text = "Invalid Contact Number";
                btnRegister_Student.Enabled = false;
            }
        }

        private void txtStudent_Email_TextChanged(object sender, EventArgs e)
        {
            //check whether user user have enter a valid data
            Profile email = new Profile(this.txtStudent_Email.Text);
            if (email.IsEmailValid())
            {
                lblStudent_Email_error.Text = "";
                if (lblStudent_Address_error.Text == "Invalid Address" || lblStudent_Contact_error.Text == "Invalid Contact Number"
                    || lblStudent_Name_error.Text == "Invalid Student name" || lblStudent_Username_error.Text == "Invalid Username")
                {
                    btnRegister_Student.Enabled = false;
                }
                else if (txtStudent_Contact.Text == "" || txtStudent_Address.Text == ""
                    || txtStudent_Name.Text == "" || txtStudent_Username.Text == "")
                {
                    btnRegister_Student.Enabled = false;
                }
                else
                {
                    btnRegister_Student.Enabled = true;
                }  
            }
            else
            {
                lblStudent_Email_error.Text = "Invalid Email Address";
                btnRegister_Student.Enabled = false;
            }
        }

        private void txtStudent_Address_TextChanged(object sender, EventArgs e)
        {
            //check whether user user have enter a valid data
            Profile address = new Profile(this.txtStudent_Address.Text);
            if (address.IsStringValid())
            {
                lblStudent_Address_error.Text = "";
                if (lblStudent_Contact_error.Text == "Invalid Contact Number" || lblStudent_Email_error.Text == "Invalid Email Address"
                    || lblStudent_Name_error.Text == "Invalid Student name" || lblStudent_Username_error.Text == "Invalid Username")
                {
                    btnRegister_Student.Enabled = false;
                }
                else if (txtStudent_Contact.Text == "" || txtStudent_Email.Text == ""
                    || txtStudent_Name.Text == "" || txtStudent_Username.Text == "")
                {
                    btnRegister_Student.Enabled = false;
                }
                else
                {
                    btnRegister_Student.Enabled = true;
                }
            }
            else
            {
                lblStudent_Address_error.Text = "Invalid Address";
                btnRegister_Student.Enabled = false;
            }
        }

        private void txtStudent_Username_TextChanged(object sender, EventArgs e)
        {
            //check whether user user have enter a valid data
            Profile username = new Profile(this.txtStudent_Username.Text);
            if (username.IsStringValid())
            {
                lblStudent_Username_error.Text = "";
                if (lblStudent_Contact_error.Text == "Invalid Contact Number" || lblStudent_Email_error.Text == "Invalid Email Address"
                    || lblStudent_Name_error.Text == "Invalid Student name" || lblStudent_Address_error.Text == "Invalid Address")
                {
                    btnRegister_Student.Enabled = false;
                }
                else if (txtStudent_Contact.Text == "" || txtStudent_Email.Text == ""
                    || txtStudent_Name.Text == "" || txtStudent_Address.Text == "")
                {
                    btnRegister_Student.Enabled = false;
                }
                else
                {
                    btnRegister_Student.Enabled = true;
                }
            }
            else if (txtStudent_Username.Text.Length == 0)
            {
                lblStudent_Username_error.Text = "Invalid Username";
                btnRegister_Student.Enabled = false;
            }
            else
            {
                lblStudent_Username_error.Text = "Invalid Username";
                btnRegister_Student.Enabled = false;
            }
        }

        private void txtStudent_Name_TextChanged(object sender, EventArgs e)
        {
            //check whether user user have enter a valid data
            Profile name = new Profile(this.txtStudent_Name.Text);
            if (name.IsStringValid())
            {
                lblStudent_Name_error.Text = "";
                if (lblStudent_Contact_error.Text == "Invalid Contact Number" || lblStudent_Email_error.Text == "Invalid Email Address"
                    || lblStudent_Username_error.Text == "Username too long" || lblStudent_Address_error.Text == "Invalid Address")
                {
                    
                    btnRegister_Student.Enabled = false;
                }
                else if (txtStudent_Contact.Text == "" || txtStudent_Email.Text == ""
                    || txtStudent_Username.Text == "" || txtStudent_Address.Text == "")
                {
                    
                    btnRegister_Student.Enabled = false;
                }
                else
                {
                    
                    btnRegister_Student.Enabled = true;
                }
            }
            else if(txtStudent_Name.Text.Length <= 0)
            {
                lblStudent_Name_error.Text = "Invalid Student name";
                btnRegister_Student.Enabled = false;
            }
            else
            {
                lblStudent_Name_error.Text = "Invalid Student name";
                btnRegister_Student.Enabled = false;
            }
        }

        private void btn_reset_info_Click(object sender, EventArgs e)
        {
            //reset the textbox and combobox
            txtStudent_Name.Text = String.Empty;
            txtStudent_Contact.Text = String.Empty;
            txtStudent_Email.Text = String.Empty;
            txtStudent_Address.Text = String.Empty;
            txtStudent_Username.Text = String.Empty;
            cmbStudent_Level.SelectedIndex = cmbStudent_Level.FindString("Form 1");
            lblStudent_Name_error.Text = "";
            lblStudent_Username_error.Text = "";
            lblStudent_Contact_error.Text = "";
            lblStudent_Email_error.Text = "";
            lblStudent_Address_error.Text = "";
        }

        private void btnRegister_Student_Click(object sender, EventArgs e)
        {
            //register student information into database
            DialogResult registerStudent = MessageBox.Show("Student Personal Information\n\n\nUsername: "+txtStudent_Username.Text+"\n\nName: "+txtStudent_Name.Text+
                "\n\nContact: "+txtStudent_Contact.Text+"\n\nEmail: "+txtStudent_Email.Text+"\n\nAddress: "+txtStudent_Address.Text+"\n\nLevel: "+cmbStudent_Level.Text+
                "\n\n\nComfirm Student Information", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (registerStudent == DialogResult.Yes)
            {
                //if user click yes, register user
                User UserExist = new User(this.txtStudent_Username.Text);
                int userid = UserExist.checkUsername("student");
                if (userid == -1)
                {
                    //user name exist, display error message
                    MessageBox.Show("Username Exist. Please try with another one","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    //register student
                    Student student = new Student(userid, this.txtStudent_Name.Text, this.txtStudent_Contact.Text, this.txtStudent_Email.Text, this.txtStudent_Address.Text, this.cmbStudent_Level.Text);
                    student.register_student();
                    MessageBox.Show("Student has been successfully registered.", "Registration Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reset textbox and combobox
                    txtStudent_Name.Text = String.Empty;
                    txtStudent_Contact.Text = String.Empty;
                    txtStudent_Email.Text = String.Empty;
                    txtStudent_Address.Text = String.Empty;
                    txtStudent_Username.Text = String.Empty;
                    cmbStudent_Level.SelectedIndex = cmbStudent_Level.FindString("Form 1");
                    lblStudent_Name_error.Text = "";
                    lblStudent_Username_error.Text = "";
                    lblStudent_Contact_error.Text = "";
                    lblStudent_Email_error.Text = "";
                    lblStudent_Address_error.Text = "";

                }

            }

        }
    }
}
