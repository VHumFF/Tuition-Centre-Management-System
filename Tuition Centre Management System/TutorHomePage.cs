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
            Tutor get_list = new Tutor(username);
            ArrayList subject_list = new ArrayList();
            subject_list = get_list.get_taught_subject_list();
            foreach(int item in subject_list)
            {
                lstTaught_subject_list.Items.Add(item);
                lstsubject_list.Items.Add(item);
                lstSubject_list3.Items.Add(item);
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
                string subject_id = lstTaught_subject_list.GetItemText(lstTaught_subject_list.SelectedItem);
                DialogResult create_class = MessageBox.Show("Class Information\n\n\nSubject Name : "+lblsubject_name_selected.Text+"\n\nStart Time : "+dtpStart_Time.Value.ToString("hh:mm tt")+
                    "\n\nEnd Time : "+dtpEnd_Time.Value.ToString("hh:mm tt")+"\n\nWeekday : "+cmbWeekdays.Text, "Create Class Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(create_class == DialogResult.Yes)
                {
                    Tutor obj = new Tutor(Convert.ToInt32(subject_id), this.cmbWeekdays.Text, dtpStart_Time.Value.ToString("hh:mm tt"), dtpEnd_Time.Value.ToString("hh:mm tt"));
                    obj.create_class();
                }
            }

        }

        private void lstsubject_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstClass_list.Items.Clear();
            btnEdit.Enabled= false;
            cmbWeekday2.Enabled = false;
            dtpStart_time2.Enabled = false;
            dtpEnd_time2.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled= false;
            string subject_id = lstsubject_list.GetItemText(lstsubject_list.SelectedItem);
            Tutor get_list = new Tutor(Convert.ToInt32(subject_id));
            ArrayList class_list = new ArrayList();
            class_list = get_list.get_class_list();
            foreach (int item in class_list)
            {
                lstClass_list.Items.Add(item);
            }
            if (lstsubject_list.SelectedItems.Count > 0)
            {
                Tutor obj = new Tutor(Convert.ToInt32(subject_id));
                lblsubject_name_selected1.Text = obj.get_subject_name();

            }

        }

        private void lstClass_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string class_id = lstClass_list.GetItemText(lstClass_list.SelectedItem);
            if (lstClass_list.SelectedItems.Count > 0)
            {
                Tutor obj = new Tutor(Convert.ToInt32(class_id));
                var class_info = obj.get_class_info();
                cmbWeekday2.Text = class_info.Item1;
                dtpStart_time2.Text = class_info.Item2;
                dtpEnd_time2.Text = class_info.Item3;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cmbWeekday2.Enabled = true;
            dtpStart_time2.Enabled = true;
            dtpEnd_time2.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtpStart_time2.Value > dtpEnd_time2.Value)
            {
                MessageBox.Show("Start Time must be earlier than End Time");
            }
            else if (dtpStart_time2.Value == dtpEnd_time2.Value)
            {
                MessageBox.Show("End Time should be greater than Start Time");
            }
            else if ((dtpEnd_time2.Value - dtpStart_time2.Value).TotalHours > 2)
            {
                MessageBox.Show("Class must not exceed 2 hours");
            }
            else if ((dtpEnd_time2.Value - dtpStart_time2.Value).TotalHours < 0.5)
            {
                MessageBox.Show("Class must not less than 30 minutes");
            }
            else
            {
                string subject_id = lstsubject_list.GetItemText(lstsubject_list.SelectedItem);
                string class_id = lstClass_list.GetItemText(lstClass_list.SelectedItem);
                DialogResult create_class = MessageBox.Show("Class Information\n\n\nSubject Name : " + lblsubject_name_selected1.Text + "\n\nStart Time : " + dtpStart_time2.Value.ToString("hh:mm tt") +
                    "\n\nEnd Time : " + dtpEnd_time2.Value.ToString("hh:mm tt") + "\n\nWeekday : " + cmbWeekday2.Text, "Update Class Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (create_class == DialogResult.Yes)
                {
                    Tutor obj = new Tutor(Convert.ToInt32(class_id), this.cmbWeekday2.Text, dtpStart_time2.Value.ToString("hh:mm tt"), dtpEnd_time2.Value.ToString("hh:mm tt"));
                    obj.update_class();
                    cmbWeekday2.Enabled = false;
                    dtpStart_time2.Enabled = false;
                    dtpEnd_time2.Enabled = false;
                    btnUpdate.Enabled = false;

                    Tutor obj2 = new Tutor(Convert.ToInt32(class_id));
                    var class_info = obj2.get_class_info();
                    cmbWeekday2.Text = class_info.Item1;
                    dtpStart_time2.Text = class_info.Item2;
                    dtpEnd_time2.Text = class_info.Item3;
                    btnEdit.Enabled = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string class_id = lstClass_list.GetItemText(lstClass_list.SelectedItem);
            if (lstClass_list.SelectedItems.Count > 0)
            {
                DialogResult create_class = MessageBox.Show("Click Yes to Delete Class", "Delete Class Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (create_class == DialogResult.Yes)
                {
                    Tutor obj = new Tutor(Convert.ToInt32(class_id));
                    obj.delete_class();
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    string subject_id = lstsubject_list.GetItemText(lstsubject_list.SelectedItem);
                    lstClass_list.Items.Clear();
                    Tutor get_list = new Tutor(Convert.ToInt32(subject_id));
                    ArrayList class_list = new ArrayList();
                    class_list = get_list.get_class_list();
                    foreach (int item in class_list)
                    {
                        lstClass_list.Items.Add(item);
                    }
                }
                

            }
        }

        private void lstSubject_list3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subject_id = lstSubject_list3.GetItemText(lstSubject_list3.SelectedItem);
            dgvStudentList.Rows.Clear();

            if (lstSubject_list3.SelectedItems.Count > 0)
            {
                Tutor obj = new Tutor(Convert.ToInt32(subject_id));
                lblSubject_name_selected3.Text = obj.get_subject_name();
                ArrayList stu_id_list = new ArrayList();
                stu_id_list = obj.get_student_id_list();
                foreach(int item in stu_id_list)
                {
                    Tutor obj1 = new Tutor(item);
                    var student_info = obj1.get_student_info();
                    dgvStudentList.Rows.Add(student_info.Item1, student_info.Item2, student_info.Item3, student_info.Item4, student_info.Item5);
                }
            }
        }

    }
}
