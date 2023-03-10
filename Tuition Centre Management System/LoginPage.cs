using System.Data;

namespace Tuition_Centre_Management_System
{
    public partial class frmLoginPage : Form
    {
        
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string test_account;
            User info = new User(txtUsername.Text, txtPassword.Text, txtPassword.PasswordChar);
            test_account = info.login();
            if (test_account == "receptionist")
            {
                //open Receptionist page
                ReceptionistHomePage r = new ReceptionistHomePage(txtUsername.Text, test_account);
                r.ShowDialog();

            }
            else if (test_account == "student")
            {
                //open student page
                StudentHomePage s = new StudentHomePage(txtUsername.Text, test_account);
                s.ShowDialog();
  
            }
            else if (test_account == "tutor")
            {
                //open tutor page
                TutorHomePage t = new TutorHomePage(txtUsername.Text, test_account);
                t.ShowDialog();

            }
            else if (test_account == "admin")
            {
                //open admin page
                AdminHomePage a = new AdminHomePage(txtUsername.Text, test_account);
                a.ShowDialog();

            }
            else if (test_account == "Invalid")
            {

                MessageBox.Show("Invalid Username or Password.\nPlease Try again.");
            }
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void picboxShowPass_Click(object sender, EventArgs e)
        {
            User info = new User(txtUsername.Text, txtPassword.Text, txtPassword.PasswordChar);
            char PasswordChar = info.displayPassword(); //call function to display password or mask password
            this.txtPassword.PasswordChar = PasswordChar;//mask and unmask password
        }

    }
}