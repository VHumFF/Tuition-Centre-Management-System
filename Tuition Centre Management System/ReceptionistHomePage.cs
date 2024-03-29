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
using System.Collections;
using System.Reflection;

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


            Receptionist r_list = new Receptionist();
            ArrayList request_list = new ArrayList();
            request_list = r_list.getSubject_change_RequestList();
            foreach(var item in request_list)
            {
                lstRequest_sub_change.Items.Add(item);
            }

            //get student id of student who they have completed their studies
            Receptionist s_list = new Receptionist();
            ArrayList stu_list = new ArrayList();
            stu_list = s_list.getStudentid_Studies_complete();
            foreach (var item in stu_list)
            {
                lstStudent_Complete_studies.Items.Add(item);
            }

            Receptionist p_list = new Receptionist();
            ArrayList payment_list = new ArrayList();
            payment_list = p_list.getPaymentlist();
            foreach(var item in payment_list)
            {
                lstPayment_list.Items.Add(item);
            }
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
                    || lblStudent_Username_error.Text == "Invalid Username" || lblStudent_Address_error.Text == "Invalid Address")
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
                    Receptionist student = new Receptionist(userid, this.txtStudent_Name.Text, this.txtStudent_Contact.Text, this.txtStudent_Email.Text, this.txtStudent_Address.Text, this.cmbStudent_Level.Text);
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

        private void cmbStudent_from_level_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset list, button and label
            btnEnroll_Student.Enabled = false;
            lstSubjectList.Items.Clear();
            lblStudent_name2.Text = "Student Name : ";
            lstStudent_List.Items.Clear();

            //reload student and subject list from select level
            Receptionist s_list = new Receptionist(this.cmbStudent_from_level.Text);
            ArrayList student_ID_list = new ArrayList();
            ArrayList subject_list = new ArrayList();
            student_ID_list = s_list.getStudentIDList();
            foreach(var item in student_ID_list)
            {
                lstStudent_List.Items.Add(item);
            }
            subject_list = s_list.getSubjectList();
            foreach (var item in subject_list)
            {
                lstSubjectList.Items.Add(item);
            }

           


        }

        private void lstStudent_List_SelectedIndexChanged(object sender, EventArgs e)
        {
           //get the selected student id from the listbox
            string stu_id = lstStudent_List.GetItemText(lstStudent_List.SelectedItem);

            //ensure that user select a value
            if(stu_id.Length > 0)
            {
                //covert string to integer for student id
                int id = Convert.ToInt32(stu_id);
                Receptionist getname = new Receptionist(id);
                string name = getname.getStudentName();

                //display the name of the selected student id
                lblStudent_name2.Text = "Student Name : " + name;
                btnEnroll_Student.Enabled = true;
            }



        }

        private void btnEnroll_Student_Click(object sender, EventArgs e)
        {
            //make sure that all necessary value have been selected before enable the enroll button
            if (lstStudent_List.SelectedItems.Count > 0 && cmbStudent_from_level.SelectedIndex > -1 && lstSubjectList.SelectedItems.Count > 0)
            {
                string s_id = lstStudent_List.GetItemText(lstStudent_List.SelectedItem);
                int id = Convert.ToInt32(s_id);

                Receptionist obj1 = new Receptionist(this.cmbStudent_from_level.Text, id);
                string selected_subject = lstSubjectList.GetItemText(lstSubjectList.SelectedItem);
                //display message if enroll successful
                if (obj1.enrollStudent(selected_subject))
                {
                    MessageBox.Show("Student have been enrolled successfully.", "Student Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void lstRequest_sub_change_SelectedIndexChanged(object sender, EventArgs e)
        {
            string request_id = lstRequest_sub_change.GetItemText(lstRequest_sub_change.SelectedItem);

            //ensure user have selected a value
            if (lstRequest_sub_change.SelectedItems.Count > 0)
            {
                //display subject change request information
                Receptionist receptionistobj = new Receptionist(Convert.ToInt32(request_id));
                var request_info = receptionistobj.getRequestInfo();
                lblStudent_name_request.Text = "Student Name : "+request_info[0];
                lblSubject_Change_From.Text = "Request to change from : " + request_info[1] + " ===> " + request_info[2];
                btnApprove.Enabled= true;
            }
            
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            //Aprove student subject change request
            int request_id = Convert.ToInt32(lstRequest_sub_change.GetItemText(lstRequest_sub_change.SelectedItem));
            Receptionist receptionistobj = new Receptionist(request_id);
            receptionistobj.approve_sub_change_request();
            MessageBox.Show("Student subject have been updated.","Subject Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //refresh and reset request list and button
            Receptionist r_list = new Receptionist();
            ArrayList request_list = new ArrayList();
            request_list = r_list.getSubject_change_RequestList();
            lstRequest_sub_change.Items.Clear();
            btnApprove.Enabled= false;
            foreach (var item in request_list)
            {
                lstRequest_sub_change.Items.Add(item);
            }
        }

        private void lstStudent_Complete_studies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stu_id = lstStudent_Complete_studies.GetItemText(lstStudent_Complete_studies.SelectedItem);


            if (lstStudent_Complete_studies.SelectedItems.Count > 0)
            {
                //display student progress information
                Receptionist obj = new Receptionist(Convert.ToInt32(stu_id));
                var student_info = obj.getStudent_complete_studies_info();
                lblStudent_name_progress2.Text = student_info[0];
                lblStudent_level_progress2.Text = student_info[1];
                lblSubject1.Text = student_info[2];
                lblSubject2.Text = student_info[3];
                lblSubject3.Text = student_info[4];

                btnProgress_student.Enabled = true;
            }
        }

        private void btnProgress_student_Click(object sender, EventArgs e)
        {
            //progress student to next level
            string stu_id = lstStudent_Complete_studies.GetItemText(lstStudent_Complete_studies.SelectedItem);
            Receptionist obj = new Receptionist(this.lblStudent_level_progress2.Text, Convert.ToInt32(stu_id));
            bool progress = obj.progress_Student_level();
            if (progress)
            {
                //reset button, student list, and label
                btnProgress_student.Enabled = false;
                Receptionist s_list = new Receptionist();
                ArrayList stu_list = new ArrayList();
                stu_list = s_list.getStudentid_Studies_complete();
                lstStudent_Complete_studies.Items.Clear();
                lblStudent_name_progress2.Text = "";
                lblStudent_level_progress2.Text = "";
                lblSubject1.Text = "";
                lblSubject2.Text = "";
                lblSubject3.Text = "";
                foreach (var item in stu_list)
                {
                    lstStudent_Complete_studies.Items.Add(item);
                }
            }
        }

        private void lstPayment_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string payment_id = lstPayment_list.GetItemText(lstPayment_list.SelectedItem);

            if (lstPayment_list.SelectedItems.Count > 0)
            {
                //display payment information
                Receptionist obj = new Receptionist(Convert.ToInt32(payment_id));
                var payment_info = obj.getPaymentInfo();
                Receptionist getname = new Receptionist(payment_info.Item1);
                string name = getname.getStudentName();
                lblPayment_student_name.Text = "Student Name : " + name;
                lblPaid_amount.Text = "Paid Amount : RM" + payment_info.Item2;

                btnAcceptPayment.Enabled = true;
            }
        }

        private void btnAcceptPayment_Click(object sender, EventArgs e)
        {
            //accept payment from student
            string payment_id = lstPayment_list.GetItemText(lstPayment_list.SelectedItem);
            Receptionist obj = new Receptionist(Convert.ToInt32(payment_id));

            int receipt_id = obj.accept_payment();
            MessageBox.Show("Payment accepted, payment receipt have been generated", "Payment Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //Open receipt
            Receipt viewreceipt = new Receipt(receipt_id);
            viewreceipt.ShowDialog();

            //reset button and list
            btnAcceptPayment.Enabled = false;
            lstPayment_list.Items.Clear();

            Receptionist p_list = new Receptionist();
            ArrayList payment_list = new ArrayList();
            payment_list = p_list.getPaymentlist();
            foreach (var item in payment_list)
            {
                lstPayment_list.Items.Add(item);
            }
        }
    }
}

