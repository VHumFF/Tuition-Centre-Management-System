using System;
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
    public partial class changePassword : Form
    {
        public static string username;
        public changePassword(string uname)
        {
            InitializeComponent();
            username = uname;
            lblusername.Text = username;
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            if(txtcurrentpass.Text.Length == 0)
            {
                lblcurrentpasserror.Text = "Please enter password";
            }
            else if(txtnewpass.Text == txtcurrentpass.Text)
            {
                MessageBox.Show("New password cannot be same as old password","Password change error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult comfirm_cp = MessageBox.Show("Comfirm to change password", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (comfirm_cp == DialogResult.Yes)
                {
                    User newpassword = new User(username, this.txtnewpass.Text, this.txtcurrentpass.Text);
                    newpassword.changepassword();
                    this.Close();

                }
                else if (comfirm_cp == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void txtnewpass_TextChanged(object sender, EventArgs e)
        {
            if(txtnewpass.Text.Length > 50)
            {
                lblnewpasserror.Text = "Password is too long";
                btnchangepass.Enabled = false;

            }
            else if(txtnewpass.Text.Length == 0)
            {
                lblnewpasserror.Text = "Please enter password";
                btnchangepass.Enabled = false;

            }
            else if (txtcomfirmpass.Text == txtnewpass.Text && txtnewpass.Text.Length != 0)
            {
                lblnewpasserror.Text = "";
                lblcomfirmpasserror.Text = "";
                btnchangepass.Enabled = true;
            }
            else if (txtcomfirmpass.Text != txtnewpass.Text)
            {
                lblcomfirmpasserror.Text = "Password do not match";
                btnchangepass.Enabled = false;
            }
            else
            {
                lblnewpasserror.Text = "";

            }
        }

        private void txtcomfirmpass_TextChanged(object sender, EventArgs e)
        {
            if(txtcomfirmpass.Text != txtnewpass.Text)
            {
                lblcomfirmpasserror.Text = "Password do not match";
                btnchangepass.Enabled = false;
            }
            else if (txtnewpass.Text.Length == 0)
            {
                lblnewpasserror.Text = "Please enter password";
                btnchangepass.Enabled = false;
            }
            else if (txtnewpass.Text.Length > 50)
            {
                lblnewpasserror.Text = "Password is too long";
                btnchangepass.Enabled = false;

            }
            else if (txtcomfirmpass.Text == txtnewpass.Text && txtnewpass.Text.Length != 0)
            {
                lblnewpasserror.Text = "";
                lblcomfirmpasserror.Text = "";
                btnchangepass.Enabled = true;
            }
            else
            {
                lblcomfirmpasserror.Text = "";
                btnchangepass.Enabled = true;
            }
        }

        private void txtcomfirmpass_Click(object sender, EventArgs e)
        {
            if(txtnewpass.Text.Length == 0)
            {
                lblnewpasserror.Text = "Please enter password";
                btnchangepass.Enabled = false;
            }
        }

        private void txtcurrentpass_TextChanged(object sender, EventArgs e)
        {
            if(txtcurrentpass.Text.Length > 0)
            {
                lblcurrentpasserror.Text = "";
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
