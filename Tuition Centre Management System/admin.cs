using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tuition_Centre_Management_System
{
    internal class admin
    {

        private int userid;
        private string tutor_name;
        private string tutor_contact;
        private string tutor_email;
        private string tutor_address;
        private string tutor_level;
        private int tutor_id;



        public admin(int uid, string t_name, string t_contact, string t_email, string t_address, string t_level)
        {
            userid = uid;
            tutor_name = t_name;
            tutor_contact = t_contact;
            tutor_email = t_email;
            tutor_address = t_address;
            tutor_level = t_level;

        }

        public admin(int id)
        {
            tutor_id = id;
        }
        public admin()
        {

        }

        public void register_tutor()
        {
            int level_id = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection

            //get level id
            SqlCommand cmd = new SqlCommand("Select id from level where level = '" + tutor_level + "'", con);
            SqlDataReader getlevelID;
            getlevelID = cmd.ExecuteReader();
            if (getlevelID.Read())
            {
                level_id = getlevelID.GetInt32(0);
                getlevelID.Close();
            }

            //insert tutor infomation into tutor table
            SqlCommand cmd2 = new SqlCommand("insert into tutor (UserId, name, contact, email, address, levelId) values (" + userid + ",'" + tutor_name + "','"
                + tutor_contact + "','" + tutor_email + "','" + tutor_address + "'," + level_id + ")", con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }


        public ArrayList getTutorIDList()
        {
            ArrayList t_id = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select id from tutor", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                t_id.Add(reader.GetInt32(0));
            }


            con.Close();
            return t_id;
        }


        public Tuple<string, string, string, string, string> getTutorInfo()
        {
            string name = "";
            string contact = "";
            string email = "";
            string address = "";
            string t_level = "";

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select name, contact, email, address from tutor where id = "+tutor_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader["name"].ToString();
                contact = reader["contact"].ToString();
                email = reader["email"].ToString();
                address = reader["address"].ToString();
            }

            reader.Close();
            SqlCommand cmd2 = new SqlCommand("Select level from level where id = (select levelid from tutor where id = "+tutor_id+")", con);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                t_level = reader2["level"].ToString();
            }


            var tutor_info = Tuple.Create(name, contact, email, address, t_level);

            con.Close();
            return tutor_info;


        }


        public void deleteTutor()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Update subject set tutorID = NULL where tutorid = "+tutor_id, con);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("Delete from users where id = (select userid from tutor where id = "+tutor_id+")", con);
            cmd2.ExecuteNonQuery();
           
        }




    }
}
