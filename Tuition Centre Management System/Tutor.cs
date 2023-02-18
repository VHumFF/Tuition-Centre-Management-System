using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuition_Centre_Management_System
{
    internal class Tutor
    {
        private string username;
        private int subject_id;

        public Tutor(string user_name)
        {
            username = user_name;
        }

        public Tutor(int sub_id)
        {
            subject_id = sub_id;
        }

        public ArrayList get_taught_subject_list()
        {
            ArrayList sub_list = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select id from subject where tutorid = (select id from tutor where userid = (select id from users where username = '"+username+"'))", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sub_list.Add(reader.GetInt32(0));
            }
            con.Close();
            return sub_list;
        }

        public string get_subject_name()
        {
            string sub_name = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select SubjectName from Subject where id = " + subject_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                sub_name = reader["SubjectName"].ToString();
                con.Close();
                return sub_name;
            }

            con.Close();
            return sub_name;
        }

    }

    

}
