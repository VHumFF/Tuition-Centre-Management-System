using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tuition_Centre_Management_System
{
    internal class Student
    {
        private int userid;
        private string student_name;
        private string student_contact;
        private string student_email;
        private string student_address;
        private string student_level;


        public Student(int uid, string s_name, string s_contact, string s_email, string s_address, string s_level)
        {
            userid = uid;
            student_name = s_name;
            student_contact = s_contact;
            student_email = s_email;
            student_address = s_address;
            student_level = s_level;
        }
        public void register_student()
        {
            int level_id = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection

            //get level id
            SqlCommand cmd = new SqlCommand("Select id from level where level = '"+student_level+"'", con);
            SqlDataReader getlevelID;
            getlevelID = cmd.ExecuteReader();
            if (getlevelID.Read())
            {
                level_id = getlevelID.GetInt32(0);
                getlevelID.Close();
            }

            SqlCommand cmd2 = new SqlCommand("insert into student (UserId, name, contact, email, address, levelId) values ("+userid+",'"+student_name+"','"+student_contact+"','"+student_email+"','"+student_address+"',"+level_id+")", con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }
    }


}
