using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tuition_Centre_Management_System
{
    internal class Profile
    {
        private string role;
        private string username;



        public Profile(string u, string r)
        {
            username = u;
            role = r;

        }

        public List<String> getProfile()
        {
            string name, email, contact, address;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection
            
            //execute command and read from database
            SqlCommand cmd = new SqlCommand("Select name, email, contact, address from " + role + " where UserID = (select id from Users where username = '" + username + "')", con);
            //SqlCommand cmd = new SqlCommand("Select name, email, contact, address from " + role +" where UserID = (select id from Users where username = '" + username + "')", con);
            SqlDataReader userinfo;
            userinfo = cmd.ExecuteReader();
            
            if(userinfo.Read())
            {
                email = userinfo["email"].ToString();
                name = userinfo["name"].ToString();
                contact = userinfo["contact"].ToString();
                address = userinfo["address"].ToString();


                var info = new List<String>() { name, contact, email, address };
                return info;
            }
            else
            {
                var info = new List<String>() { "No Data", "No Data", "No Data", "No Data" };
                return info;
            }
        }
    }

}
