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
        private string weekday;
        private string start_time;
        private string end_time;
        private int class_id;
        private int student_id;

        public Tutor(int id, string week_day, string startTime, string endTime)
        {
            subject_id= id;
            class_id= id;
            weekday= week_day;
            start_time= startTime;
            end_time= endTime;
        }

        public Tutor(string user_name)
        {
            username = user_name;
        }

        public Tutor(int id)
        {
            subject_id = id;
            class_id = id;
            student_id = id;
        }

        public ArrayList get_taught_subject_list()
        {
            //get a list of subject the tutor have been assigned to
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
            //get the name of subject with subject id
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


        public void create_class()
        {
            bool time_valid = check_timeslot(weekday, start_time, end_time);
            if(time_valid)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into class(subjectid, Weekday, StartTime, EndTime) values(" + subject_id + ",'" + weekday + "','" + start_time + "','" + end_time + "')", con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            
        }

        private bool check_timeslot(string wday, string stime, string etime)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //SqlCommand cmd = new SqlCommand("select * from class where weekday = '"+wday+"' and starttime >= '"+stime+"' and endtime <= '"+etime+"' and starttime < '"+etime+"' and endtime > '"+stime+"'" , con);
            SqlCommand cmd = new SqlCommand("select * from class where weekday = '" + wday + "' and ('"+stime+"' between starttime and endtime or '"+etime+"' between starttime and endtime)", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("TimeSlot Occupied, Please try another timeslot");
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }

        public ArrayList get_class_list()
        {
            ArrayList class_list = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select id from class where subjectid = "+subject_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                class_list.Add(reader.GetInt32(0));
            }
            con.Close();
            return class_list;
        }

        public Tuple<string, string, string> get_class_info()
        {
            string weekday = "";
            string stime = "";
            string etime = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select weekday, starttime, endtime from class where id = " + class_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                weekday = reader["weekday"].ToString();
                stime = reader["starttime"].ToString();
                etime = reader["endtime"].ToString();
            }
            var class_info = Tuple.Create(weekday, stime, etime);
            con.Close();
            return class_info;
        }

        public void update_class()
        {
            bool time_valid = check_timeslot(weekday, start_time, end_time);
            if(time_valid)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("update class set starttime = '" + start_time + "', endtime = '" + end_time + "',weekday = '" + weekday + "' where id = " + class_id, con);
                cmd.ExecuteNonQuery();
                con.Close() ;
            }


        }

        public void delete_class()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from class where id = " + class_id, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public ArrayList get_student_id_list()
        {
            ArrayList stu_id_list = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select studentid from enroll where subjectid = "+subject_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                stu_id_list.Add(reader.GetInt32(0));
            }
            con.Close();
            return stu_id_list;
        }

        public Tuple<int, string, string ,string, string> get_student_info()
        {
            int id = 0;
            string name = "", contact = "", email = "", address = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select id, name, contact, email, address from student where id = "+student_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
                name = Convert.ToString(reader["name"]);
                contact = Convert.ToString(reader["contact"]);
                email = Convert.ToString(reader["email"]);
                address = Convert.ToString(reader["address"]);
            }

            var student_info = Tuple.Create(id, name, email, contact, address);
            return student_info;
        }

    }

    

}
