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
    public partial class Receipt : Form
    {
        public static int receipt_id;
        public Receipt(int r_id)
        {
            InitializeComponent();
            receipt_id= r_id;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            Student obj = new Student(receipt_id);
            var receipt_info = obj.get_receipt_info();
            

            //display receipt info
            txtReceiptID.Text = receipt_id.ToString();
            txtDate.Text = receipt_info.Item1;
            txtAmount.Text = "RM"+receipt_info.Item2.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
