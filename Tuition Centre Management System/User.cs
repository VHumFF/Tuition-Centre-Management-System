using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuition_Centre_Management_System
{
    internal class User
    {
        private string _username;
        private string _password;
        private char _showPassword;

        //constructor
        public User(string u, string p, char displayp)
        {
            _username = u;
            _password = p;
            _showPassword = displayp;

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

    }
}

