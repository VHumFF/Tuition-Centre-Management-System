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
    public partial class StudentHomePage : Form
    {
        public static string username;
        public static string userrole;

        public StudentHomePage(string uname, string urole)
        {
            InitializeComponent();
            username = uname;
            userrole = urole;
        }

        private void StudentHomePage_Load(object sender, EventArgs e)
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



            Student get_list = new Student(username);
            ArrayList subject_list = new ArrayList();
            ArrayList subject_change_list = new ArrayList();
            subject_list = get_list.get_enrolled_subject();
            subject_change_list = get_list.get_subject_change_list();

            //load enrolled subject list to respective listbox
            foreach (int item in subject_list)
            {
                lstSubject_list.Items.Add(item);
                lstcurrent_erolled_sub.Items.Add(item);
                lstSubject_enrolled_list.Items.Add(item);
            }
            //load subject list
            foreach(int item in subject_change_list)
            {
                lstchange_Sub_list.Items.Add(item);
            }

            //load request info
            Student get_r_info = new Student(username);
            var r_info = get_r_info.get_requset_info();
            lblRequestid.Text = r_info.Item1;
            lblCurrent_sub1.Text = r_info.Item2;
            lblNew_Sub.Text = r_info.Item3;

            if(lblRequestid.Text == "")
            {
                lblMessage.Text = "You do not have any pending request";
            }
            else
            {
                btnWithdraw.Enabled = true;
            }

            //load list of unpaid fee
            ArrayList payment_id_list = new ArrayList();
            payment_id_list = get_list.get_unpaid_fee_list();
            foreach(int item in payment_id_list)
            {
                lstUnpaidfee.Items.Add(item);
            }

            //load list of receipt
            ArrayList receipt_id_list = new ArrayList();
            receipt_id_list = get_list.get_receipt();
            foreach (int item in receipt_id_list)
            {
                lstReceipt.Items.Add(item);
            }

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
            //open change password window
            changePassword cp = new changePassword(username);
            cp.ShowDialog();
        }

        private void lstSubject_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subject_id = lstSubject_list.GetItemText(lstSubject_list.SelectedItem);
            dgvClass_Shedule.Rows.Clear();

            //make sure user select value
            if (lstSubject_list.SelectedItems.Count > 0)
            {
                Tutor obj = new Tutor(Convert.ToInt32(subject_id));
                lblSubject_name_selected.Text = obj.get_subject_name();

                //load class id list
                ArrayList class_id_list = new ArrayList();
                class_id_list = obj.get_class_list();
                foreach (int item in class_id_list)
                {
                    Student obj1 = new Student(item);
                    var class_info = obj1.get_class_schedule();
                    dgvClass_Shedule.Rows.Add(class_info.Item1, class_info.Item2, class_info.Item3);
                }
            }
        }

        private void lstcurrent_erolled_sub_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subject_id = lstcurrent_erolled_sub.GetItemText(lstcurrent_erolled_sub.SelectedItem);

            //ensure user select a value
            if (lstcurrent_erolled_sub.SelectedItems.Count > 0)
            {
                Tutor obj = new Tutor(Convert.ToInt32(subject_id));
                lblcurrent_sub_name.Text = obj.get_subject_name();
            }
            if(lstchange_Sub_list.SelectedItems.Count > 0 && lstcurrent_erolled_sub.SelectedItems.Count > 0)
            {
                btnRequest.Enabled = true;
            }
        }

        private void lstchange_Sub_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subject_id = lstchange_Sub_list.GetItemText(lstchange_Sub_list.SelectedItem);

            if (lstchange_Sub_list.SelectedItems.Count > 0)
            {
                Tutor obj = new Tutor(Convert.ToInt32(subject_id));
                lblChange_sub_name.Text = obj.get_subject_name();
            }
            if (lstchange_Sub_list.SelectedItems.Count > 0 && lstcurrent_erolled_sub.SelectedItems.Count > 0)
            {
                btnRequest.Enabled = true;
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            string subject_id = lstchange_Sub_list.GetItemText(lstchange_Sub_list.SelectedItem);
            bool already_enrolled = false;
            //check whether requested change subject already enrolled
            foreach(int item in lstcurrent_erolled_sub.Items)
            {
                if(item == Convert.ToInt32(subject_id))
                {
                    MessageBox.Show("Already enrolled in the subject");
                    already_enrolled = true;
                }
            }
            if (!already_enrolled)
            {
                DialogResult send_request = MessageBox.Show("Click \"Yes\" to send subject change request", "Submit Subject Change Request", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (send_request == DialogResult.Yes)
                {
                    Student obj = new Student(username, Convert.ToInt32(this.lstcurrent_erolled_sub.SelectedItem), Convert.ToInt32(this.lstchange_Sub_list.SelectedItem));
                    obj.request_sub_change();
                    btnRequest.Enabled = false;

                    //reset request list and label
                    Student get_r_info = new Student(username);
                    var r_info = get_r_info.get_requset_info();
                    lblRequestid.Text = r_info.Item1;
                    lblCurrent_sub1.Text = r_info.Item2;
                    lblNew_Sub.Text = r_info.Item3;
                    btnWithdraw.Enabled = true;
                    lblMessage.Text = "";
                }
                
            }

                   
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            DialogResult wd_req = MessageBox.Show("Click \"Yes\" to withdraw subject change request", "Withdraw Subject Change Request", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (wd_req == DialogResult.Yes)
            {
                Student obj = new Student(Convert.ToInt32(this.lblRequestid.Text));
                obj.withdraw_request();

                //reset button and label
                btnWithdraw.Enabled = false;
                lblMessage.Text = "You do not have any pending request";
                lblRequestid.Text = "";
                lblCurrent_sub1.Text = "";
                lblNew_Sub.Text = "";
            }
            

        }


        private void lstSubject_enrolled_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subject_id = lstSubject_enrolled_list.GetItemText(lstSubject_enrolled_list.SelectedItem);

            if (lstSubject_enrolled_list.SelectedItems.Count > 0)
            {
                Tutor obj = new Tutor(Convert.ToInt32(subject_id));
                lblSubject_name4.Text = obj.get_subject_name();

                Student obj2 = new Student(Convert.ToInt32(subject_id), username);
                lblSub_progress.Text = obj2.get_subject_progress();

                btnComplete.Enabled = true;
            }
            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (lblSub_progress.Text == "Completed")
            {
                MessageBox.Show("Subject already completed", "Complete Studies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lblSub_progress.Text == "Subject change pending")
            {
                MessageBox.Show("Cannot complete a subject that is under change request", "Complete Studies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string subject_id = lstSubject_enrolled_list.GetItemText(lstSubject_enrolled_list.SelectedItem);
                DialogResult complete_studies = MessageBox.Show("Click \"Yes\" to complete subject studies", "Complete Subject Studies", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (complete_studies == DialogResult.Yes)
                {
                   
                    Student obj = new Student(Convert.ToInt32(subject_id), username);
                    obj.complete_subject_studies();

                    //reset label
                    lblSub_progress.Text = "";
                    lblSubject_name4.Text = "";
                    btnComplete.Enabled = false;
                }
            }
        }

        private void lstUnpaidfee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string payment_id = lstUnpaidfee.GetItemText(lstUnpaidfee.SelectedItem);

            if (lstUnpaidfee.SelectedItems.Count > 0)
            {
                //display unpaid fee info
                Student obj = new Student(Convert.ToInt32(payment_id));
                string oustanding = obj.get_unpaid_fee_info().ToString();
                lblOutstanding.Text = "Outstanding : RM" + oustanding;
                btnPay.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string payment_id = lstUnpaidfee.GetItemText(lstUnpaidfee.SelectedItem);
            DialogResult pay = MessageBox.Show("Click \"Yes\"to comfirm transaction", "Comfirm Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (pay == DialogResult.Yes)
            {
                Student obj = new Student(Convert.ToInt32(payment_id));
                obj.pay_unpaid_fee();

                //reset label
                lblOutstanding.Text = "Outstanding : ";
                btnPay.Enabled = false;
                lstUnpaidfee.Items.Clear();

                //refresh list
                Student get_list = new Student(username);
                ArrayList payment_id_list = new ArrayList();
                payment_id_list = get_list.get_unpaid_fee_list();
                foreach (int item in payment_id_list)
                {
                    lstUnpaidfee.Items.Add(item);
                }
            }
        }

        private void lstReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //makesure user select a value
            if (lstReceipt.SelectedItems.Count > 0)
            {
                btnViewReceipt.Enabled = true;
            }
        }

        private void btnViewReceipt_Click(object sender, EventArgs e)
        {
            //open receipt form
            string receipt_id = lstReceipt.GetItemText(lstReceipt.SelectedItem);
            Receipt viewreceipt = new Receipt(Convert.ToInt32(receipt_id));
            viewreceipt.ShowDialog();
        }
    }
}
