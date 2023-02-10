using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tuition_Centre_Management_System
{
    internal class Profile
    {
        private string role;
        private string username;
        private string contact;
        private string address;
        private string email;
        private string x;



        public Profile(string u, string r)
        {
            username = u;
            role = r;

        }
        public Profile(string info) //x could be username, role, address, email.....
        {
            x = info;

        }

        public Profile(string u,string r, string cont, string addre, string em) 
        {
            username = u;
            role = r;
            contact = cont;
            email = em;
            address = addre;
        }


        public List<String> getProfile()
        {
            string name, email, contact, address;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection
            
            //execute command and read from database
            SqlCommand cmd = new SqlCommand("Select name, email, contact, address from " + role + " where UserID = (select id from Users where username = '" + username + "')", con);
            SqlDataReader userinfo;
            userinfo = cmd.ExecuteReader();
            
            //check whether there is record
            if(userinfo.Read())
            {
                email = userinfo["email"].ToString();
                name = userinfo["name"].ToString();
                contact = userinfo["contact"].ToString();
                address = userinfo["address"].ToString();

                //return user profile in list
                var info = new List<String>() { name, contact, email, address };
                return info;
            }
            else
            {
                var info = new List<String>() { "No Data", "No Data", "No Data", "No Data" };
                return info;
            }

        }


        public void updateProfile()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection
            //update user infomation
            SqlCommand cmd = new SqlCommand("Update "+role+" set contact= '"+contact+"', email= '"+email+"', address= '"+address+"' where UserID = (Select Id from Users where username = '"+username+"')",con);
            cmd.ExecuteNonQuery();
            //SqlCommand cmd = new SqlCommand("Update " + role + " set contact = '" + contact + "', email = '" + email + "', address = '" + address + "' " +
            //    "where UserID = (Select id from Users where username = '" + username + "');", con);



        }

        //validate contact number
        public bool IsContactValid()
        {
            //phone number must be less than 10 digit and more than 7 digit
            if (x.Length > 10)
            {
                return false;
            }
            else if (x.Length < 8)
            {
                return false;
            }
            else
            {
                //contact number cannot contain character other than numeric digit
                foreach (char c in x)
                {
                    if (c < '0' || c > '9')
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        //validate email address
        public bool IsEmailValid()
        {
            string regex = @"^[^@\s\.-]+@[^@\s\.-]+\.com$";
            //match email address with the regex above

            return Regex.IsMatch(x, regex, RegexOptions.IgnoreCase);
        }


        //validate address
        public bool IsAddressValid()
        {
            //Address cannot more than 50 characters
            if (x.Length > 50)
            {
                return false;
            }
            //user must enter value
            else if (x.Length <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}
