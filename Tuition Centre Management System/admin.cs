using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

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
        private int recep_id;
        private string recep_name;
        private string recep_contact;
        private string recep_email;
        private string recep_address;
        private int month;
        private int year;
        private int receipt_id;
        private string level;
        private int subject_id;


        public admin(int uid, string t_name, string t_contact, string t_email, string t_address, string t_level)
        {
            userid = uid;
            tutor_name = t_name;
            tutor_contact = t_contact;
            tutor_email = t_email;
            tutor_address = t_address;
            tutor_level = t_level;

        }

        public admin(int uid, string r_name, string r_contact, string r_email, string r_address)
        {
            userid = uid;
            recep_name = r_name;
            recep_contact = r_contact;
            recep_email = r_email;
            recep_address = r_address;


        }
        public admin (string l)
        {
            level = l;
        }
        public admin (int i, int ii)
        {
            month = i;
            year = ii;

            subject_id = i;
            tutor_id = ii;
        }

        public admin(int id)
        {
            tutor_id = id;
            recep_id = id;
            receipt_id = id;
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

        public ArrayList getRecepIDList()
        {
            ArrayList recep_id = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select receptionistid from receptionist", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                recep_id.Add(reader.GetInt32(0));
            }


            con.Close();
            return recep_id;
        }



        public Tuple<string, string, string, string> getRecepInfo()
        {
            string name = "";
            string contact = "";
            string email = "";
            string address = "";

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select name, contact, email, address from receptionist where receptionistid = " + recep_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader["name"].ToString();
                contact = reader["contact"].ToString();
                email = reader["email"].ToString();
                address = reader["address"].ToString();
            }

            var recep_info = Tuple.Create(name, contact, email, address);

            con.Close();
            return recep_info;


        }


        public void register_recep()
        {
            int level_id = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open(); //open connection

            SqlCommand cmd = new SqlCommand("insert into receptionist (UserId, name, contact, email, address) values (" + userid + ",'" + recep_name + "','"
                + recep_contact + "','" + recep_email + "','" + recep_address+ "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }



        public void deleteRecep()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete from users where id = (select userid from receptionist where receptionistid = " + recep_id + ")", con);
            cmd.ExecuteNonQuery();


        }


        public ArrayList getreceiptid()
        {
            ArrayList recepitID =new ArrayList();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select id from receipt where MONTH(date) = "+month+" AND YEAR(date) = "+year, con);

            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                recepitID.Add(reader.GetInt32(0));
            }

            con.Close();
            return recepitID;

        }


        public Tuple<string, decimal> getIncomeReport()
        {
            string date = "";
            decimal amount = 0;
            string r_date = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select date, amount from receipt where id = " + receipt_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                date = reader["date"].ToString();
                amount = Convert.ToDecimal(reader["amount"]);


                r_date = DateTime.Parse(date, System.Globalization.CultureInfo.CurrentCulture).ToString("dd-MM-yyyy");
            }
            var income_report = Tuple.Create(r_date, amount);


            con.Close();
            return income_report;
        }


        public ArrayList getTutorIDList_with_level()
        {
            int l_id = 0;
            ArrayList t_id = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select id from level where level = '" + level+"'", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l_id = Convert.ToInt32(reader["id"]);
            }

            reader.Close();

            SqlCommand cmd2 = new SqlCommand("Select id from tutor where levelid = "+l_id, con);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                t_id.Add(reader2.GetInt32(0));
            }


            con.Close();
            return t_id;
        }

        public ArrayList getSubjectList_with_level()
        {
            int l_id = 0;
            ArrayList s_id = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select id from level where level = '" + level + "'", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                l_id = Convert.ToInt32(reader["id"]);
            }

            reader.Close();
            SqlCommand cmd2 = new SqlCommand("Select id from subject where levelid = " + l_id, con);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                s_id.Add(reader2.GetInt32(0));
            }


            con.Close();
            return s_id;
        }


        public bool assignTutorToSub()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from subject where id = "+subject_id+" and tutorID is not NULL", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                
                return false;
            }

            reader.Close();

            SqlCommand cmd2 = new SqlCommand("Update Subject set tutorID = "+tutor_id+" where id = "+subject_id, con);
            cmd2.ExecuteNonQuery();
            return true;
        }
    }
}
