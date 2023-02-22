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
    public partial class AssignTutorSubject : Form
    {
        public AssignTutorSubject()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string tutorid = lstTutorID.GetItemText(lstTutorID.SelectedItem);
            string sub_id = lstSubjectID.GetItemText(lstSubjectID.SelectedItem);

            admin obj = new admin(Convert.ToInt32(sub_id), Convert.ToInt32(tutorid));
            var assign_success = obj.assignTutorToSub();

            if (assign_success)
            {
                MessageBox.Show("Tutor :" + lblTutName.Text + " have been successfully assigned to\nSubject :" + lblsubName.Text, "Subject Assigned Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Subject:"+lblsubName.Text+" already assigned to another tutor", "Subject Assign Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset list, button and label
            btnAssign.Enabled = false;
            lstSubjectID.Items.Clear();
            lstTutorID.Items.Clear();
            lblsubName.Text= string.Empty;
            lblTutName.Text= string.Empty;

            //reload student and subject list from select level
            admin s_list = new admin(this.cmbLevel.Text);
            ArrayList tutor_ID_list = new ArrayList();
            ArrayList subject_list = new ArrayList();
            tutor_ID_list = s_list.getTutorIDList_with_level();
            foreach (var item in tutor_ID_list)
            {
                lstTutorID.Items.Add(item);
            }
            subject_list = s_list.getSubjectList_with_level() ;
            foreach (var item in subject_list)
            {
                lstSubjectID.Items.Add(item);
            }

        }

        private void lstTutorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tutorid = lstTutorID.GetItemText(lstTutorID.SelectedItem);


            if (lstTutorID.SelectedItems.Count > 0)
            {
                admin obj = new admin(Convert.ToInt32(tutorid));
                var tutor_info = obj.getTutorInfo();
                lblTutName.Text = tutor_info.Item1;

            }
            if (lstTutorID.SelectedItems.Count > 0 && lstSubjectID.SelectedItems.Count > 0)
            {
                btnAssign.Enabled= true;

            }


        }

        private void lstSubjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sub_id = lstSubjectID.GetItemText(lstSubjectID.SelectedItem);


            if (lstSubjectID.SelectedItems.Count > 0)
            {
                Tutor obj = new Tutor(Convert.ToInt32(sub_id));
                lblsubName.Text = obj.get_subject_name();

            }
            if (lstTutorID.SelectedItems.Count > 0 && lstSubjectID.SelectedItems.Count > 0)
            {
                btnAssign.Enabled= true;

            }
        }
    }
}
