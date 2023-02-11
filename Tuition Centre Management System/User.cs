using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tuition_Centre_Management_System
{
    internal class User
    {
        private string _username;
        private string _password;
        private char _showPassword;
        private string newpassword;
        private string currentpassword;
        private string _userrole;

        //constructor
        public User(string u, string p, char displayp)
        {
            _username = u;
            _password = p;
            _showPassword = displayp;

        }

        internal User(string u, string newp, string currp) 
        {
            _username = u;
            newpassword = newp;
            currentpassword = currp;
        }
        public User(string u)
        {
            _username = u;
        }

        public string login()
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection

            //execute command and read from database
            SqlCommand cmd = new SqlCommand("Select * from users where username = '" + _username + "' and password ='" + _password + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            bool validation = reader.Read();//True if there are rows else false

            //if true get user role and log in to respective page
            if(validation)
            {
                reader.Close();
                SqlCommand cmd2 = new SqlCommand("select role from users where username ='" + _username + "' and password ='" + _password + "'", con);
                string role = cmd2.ExecuteScalar().ToString();
                con.Close();
                return role;

            }
            else
            {
                status = "Invalid";
            }
            con.Close();

            return status;
        }

        public char displayPassword()
        {
            if (_showPassword == '*')
            {
                _showPassword = '\0'; //set to default value
            }
            else
            {
                _showPassword = '*'; //mask password
            }
            return _showPassword;
        }

        //method for password change
        internal void changepassword()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection

            SqlCommand cmd = new SqlCommand("Select password from users where username = '" + _username + "'", con);
            SqlDataReader readpassword;
            readpassword = cmd.ExecuteReader();
            //get the current password of the user
            if (readpassword.Read())
            {
                //compare the password in the database and the password user input
                if(currentpassword == readpassword["password"].ToString())
                {
                    readpassword.Close();
                    //update the old password with new password
                    SqlCommand cmd2 = new SqlCommand("Update users set password= '" + newpassword + "' where username = '" + _username + "'", con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Your password has been changed Successfully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("The password you entered is incorrect.", "Password Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }

        internal int checkUsername(string role)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection
            //check whether the username exist in the database
            SqlCommand cmd = new SqlCommand("Select * from users where username = '" + _username + "'", con);
            SqlDataReader usernameExist;
            usernameExist = cmd.ExecuteReader();
            if (usernameExist.Read())
            {
                //user exist return -1
                con.Close();
                return -1;
            }
            else
            {
                //if user does not exist
                //register user and return user id
                con.Close();
                int userid = registerUser(_username, role);
                return userid;
            }
        }

        private int registerUser(string username, string role)
        {
            int id = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection

            //register username with default password equal to username
            SqlCommand cmd = new SqlCommand("insert into users (username, password, role) values ('" + username + "','" + username + "','" + role + "')", con); ;
            cmd.ExecuteNonQuery();

            //retrieve user id after registered
            SqlCommand cmd2 = new SqlCommand("Select Id from users where username = '" + username + "'", con);
            SqlDataReader userid;
            userid = cmd2.ExecuteReader();
            if (userid.Read())
            {
                id = userid.GetInt32(0);
            }
            
            con.Close();
            //return user id
            return id;
        }

    }
}

