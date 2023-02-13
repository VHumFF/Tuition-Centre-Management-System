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
using System.Collections;
using System.Security.Policy;
using System.Xml.Schema;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace Tuition_Centre_Management_System
{
    internal class Receptionist
    {
        private int userid;
        private string student_name;
        private string student_contact;
        private string student_email;
        private string student_address;
        private string student_level;
        private int student_id;


        public Receptionist(int uid, string s_name, string s_contact, string s_email, string s_address, string s_level)
        {
            userid = uid;
            student_name = s_name;
            student_contact = s_contact;
            student_email = s_email;
            student_address = s_address;
            student_level = s_level;
        }

        public Receptionist(string s_level)
        {
            student_level = s_level;
        }

        public Receptionist(string s_level, int s_id)
        {
            student_level = s_level;
            student_id = s_id;
        }

        public Receptionist(int s_id)
        {
            student_id = s_id;
        }

        public Receptionist()
        {
            //default constructor
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

            //insert student infomation into student table
            SqlCommand cmd2 = new SqlCommand("insert into student (UserId, name, contact, email, address, levelId) values ("+userid+",'"+student_name+"','"
                +student_contact+"','"+student_email+"','"+student_address+"',"+level_id+")", con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }


        public ArrayList getStudentIDList()
        {
            ArrayList s_id = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select id from student where levelid = (select id from level where level = '" + student_level + "')", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s_id.Add(reader.GetInt32(0));
            }


            con.Close();
            return s_id;
        }

        public string getStudentName()
        {
            string n = "no name";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select name from student where id = '" + student_id +"';", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                n = reader["name"].ToString();
            }

            con.Close();
            return n;
        }



        public ArrayList getSubjectList()
        {
            ArrayList subject_name = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select SubjectName from subject where levelid = (select id from level where level = '" + student_level + "') and TutorID is not NULL", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                subject_name.Add(reader.GetString(0));
            }


            con.Close();
            return subject_name;
        }

        public bool enrollStudent(string subject)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select Count(*) as subject_enrolled from enroll where StudentID = " + student_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int subject_enrolled = reader.GetInt32(0);
                if(subject_enrolled == 3)
                {
                    MessageBox.Show("Student cannot enrolled more than 3 subject.\nCurrent taken Subject number : "+ subject_enrolled);
                    con.Close();
                    return false;
                }
            }
            reader.Close();

            bool registered = false;
            SqlCommand cmd2 = new SqlCommand("Select * from enroll where subjectID = (select ID from subject where subjectname = '"+subject+"' and levelID = (select id from level where level ='"+student_level+"')) and studentid = "+student_id, con);
            SqlDataReader readerSub_exist;
            readerSub_exist = cmd2.ExecuteReader();
            bool sub_exist = readerSub_exist.Read();
            if(sub_exist)
            { 
                MessageBox.Show("Student already in the subject.\n\n" + subject + "\n\nPlease enroll another subject");
                con.Close();
                return false;
            }
                
            readerSub_exist.Close();
            SqlCommand cmd3 = new SqlCommand("Select id from subject where SubjectName = '" + subject + "' and levelID = (select id from level where level ='" + student_level + "')", con);
            SqlDataReader readSub_id;
            readSub_id = cmd3.ExecuteReader();
            if (readSub_id.Read())
            {
                int sub_id = readSub_id.GetInt32(0);
                readSub_id.Close();
                SqlCommand cmd4 = new SqlCommand("insert into enroll(subjectId, studentID, Progress) values(" + sub_id + ", '" + student_id + "','In Progress')", con);
                cmd4.ExecuteNonQuery();

                SqlCommand cmd5 = new SqlCommand("Select fee from subject where SubjectName = '" + subject + "' and levelID = (select id from level where level ='" + student_level + "')", con);
                SqlDataReader readFee;
                readFee = cmd5.ExecuteReader();
                if (readFee.Read())
                {
                    
                    decimal sub_fee = readFee.GetDecimal(0);
                    readFee.Close();
                    SqlCommand cmd6 = new SqlCommand("Insert into payment(StudentID, outstanding, status) values(" + student_id + "," + sub_fee + ",'unpaid')", con);
                    cmd6.ExecuteReader();

                }


            }
            con.Close();
            return true;
        }



        public ArrayList getSubject_change_RequestList()
        {
            ArrayList request_list = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();


            SqlCommand cmd = new SqlCommand("Select id from request", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                request_list.Add(reader.GetInt32(0));
            }


            con.Close();
            return request_list;


        }

    }


}
