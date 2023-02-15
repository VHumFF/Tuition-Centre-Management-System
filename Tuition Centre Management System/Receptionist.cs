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
        private int request_id;

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

        public Receptionist(int id)//could be request id or student id
        {
            student_id = id;
            request_id= id;
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
            //get all student from the specific level
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

            //get the name of the student with student id
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

            //get list of subject from specific level and have tutor assigned
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

            //get the number of subject the student have enrolled
            SqlCommand cmd = new SqlCommand("Select Count(*) as subject_enrolled from enroll where StudentID = " + student_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int subject_enrolled = reader.GetInt32(0);
                //dont allow student to enroll new subject if already enrolled in 3
                if(subject_enrolled == 3)
                {
                    MessageBox.Show("Student cannot enrolled more than 3 subject.\nCurrent taken Subject number : "+ subject_enrolled, "Student Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    con.Close();
                    return false;
                }
            }
            reader.Close();

            //check whether student have enrolled in this subject
            SqlCommand cmd2 = new SqlCommand("Select * from enroll where subjectID = (select ID from subject where subjectname = '"+subject+"' and levelID = (select id from level where level ='"+student_level+"')) and studentid = "+student_id, con);
            SqlDataReader readerSub_exist;
            readerSub_exist = cmd2.ExecuteReader();
            bool sub_exist = readerSub_exist.Read();
            //if read rows, means student have enrolled in the subject.
            if(sub_exist)
            { 
                MessageBox.Show("Student already in the subject.\n\n" + subject + "\n\nPlease enroll another subject", "Student Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                con.Close();
                return false;
            }
                
            
            readerSub_exist.Close();

            //get the subject id using subject name and level id
            SqlCommand cmd3 = new SqlCommand("Select id from subject where SubjectName = '" + subject + "' and levelID = (select id from level where level ='" + student_level + "')", con);
            SqlDataReader readSub_id;
            readSub_id = cmd3.ExecuteReader();
            if (readSub_id.Read())
            {
                //insert new enroll subject for the student
                int sub_id = readSub_id.GetInt32(0);
                readSub_id.Close();
                SqlCommand cmd4 = new SqlCommand("insert into enroll(subjectId, studentID, Progress) values(" + sub_id + ", '" + student_id + "','In Progress')", con);
                cmd4.ExecuteNonQuery();

                //get the fee of the subject student enroll
                SqlCommand cmd5 = new SqlCommand("Select fee from subject where SubjectName = '" + subject + "' and levelID = (select id from level where level ='" + student_level + "')", con);
                SqlDataReader readFee;
                readFee = cmd5.ExecuteReader();
                if (readFee.Read())
                {
                    
                    decimal sub_fee = readFee.GetDecimal(0);
                    readFee.Close();
                    //add outstanding fees to student account
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

            //get the requeid subject change id
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

        public List<String> getRequestInfo()
        {
            string name = "";
            string current_sub_name = "";
            string new_sub_name = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select StudentID from request where id = "+request_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int stu_id = Convert.ToInt32(reader["StudentID"]);
                Receptionist getname = new Receptionist(stu_id);
                name = getname.getStudentName();

                reader.Close();


                SqlCommand cmd2 = new SqlCommand("Select CurrentSubjectID, NewSubjectID from request where id = " + request_id, con);
                SqlDataReader reader2;
                reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    string currentsubjectID = reader2["CurrentSubjectID"].ToString();
                    string newSubjectID = reader2["NewSubjectID"].ToString();

                    current_sub_name = getSubjectName(currentsubjectID);
                    new_sub_name = getSubjectName(newSubjectID);
                }


            }
            var request_info = new List<String>() { name, current_sub_name, new_sub_name};
            con.Close();
            return request_info;

        }

        private string getSubjectName(string sub_id)
        {
            string sub_name = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select SubjectName from Subject where id = " + sub_id, con);
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

        
        public void approve_sub_change_request()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select StudentID, CurrentSubjectID, NewSubjectID from request where id = " + request_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                
                int currentsubjectID = Convert.ToInt32(reader["CurrentSubjectID"].ToString());
                int newSubjectID = Convert.ToInt32(reader["NewSubjectID"].ToString());
                int stu_id = Convert.ToInt32(reader["StudentID"].ToString());
                reader.Close();
                change_enrolled_subject(stu_id, currentsubjectID, newSubjectID);

                SqlCommand cmd2 = new SqlCommand("Delete From Request Where ID = "+request_id, con);
                cmd2.ExecuteNonQuery();

            }
            con.Close();
        }

        private void change_enrolled_subject(int stu_id, int current_sub_id, int new_sub_id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Update enroll set SubjectID = "+new_sub_id+", progress = 'In Progress' Where StudentID = "+stu_id+" and SubjectID = "+current_sub_id, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }


        public ArrayList getStudentid_Studies_complete()
        {
            ArrayList stu_id = new ArrayList();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select distinct StudentID from enroll where progress = 'Completed' group by studentID having count(progress) = 3", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                stu_id.Add(reader.GetInt32(0));
            }
            
            con.Close();
            return stu_id;
        }

        private string getstudentLevel(int stu_id)
        {
            string level = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select level from level where id =(select levelid from student where id = "+stu_id+")", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                level = reader.GetString(0);
            }
            return level;

        }


        public List<string> getStudent_complete_studies_info()
        {
            string name = getStudentName();
            string level = getstudentLevel(student_id);
            List<string> sub_id_list = new List<string>();
            List<string> sub_name_list = new List<string>() { name, level};
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select subjectId from enroll where studentID ="+student_id, con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                sub_id_list.Add(reader["Subjectid"].ToString());
            }
            foreach(var id in sub_id_list)
            {
                sub_name_list.Add(getSubjectName(id));
            }
    

            return sub_name_list;

        }



        public bool progress_Student_level()
        {
            string progress_level_to = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from payment where studentid = "+student_id, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Student still have unsettle outstanding", "Student Progression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
                return false;
            }
            reader.Close();
            if(student_level == "Form 1")
            {
                progress_level_to = "Form 2";
            }
            else if (student_level == "Form 2")
            {
                progress_level_to = "Form 3";
            }
            else if(student_level == "Form 3")
            {
                progress_level_to = "Form 4";
            }
            else if(student_level == "Form 4")
            {
                progress_level_to = "Form 5";
            }
            else if(student_level == "Form 5")
            {
                SqlCommand cmd4 = new SqlCommand("Delete from users where id = (select userid from student where id = "+student_id+")", con);
                cmd4.ExecuteNonQuery();
                MessageBox.Show("Student have completed thier studies from all level.\nuser info have been deleted from the system.", "Student Progressed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                return true;


            }

            SqlCommand cmd2 = new SqlCommand("Delete from enroll where studentID = "+student_id, con);
            cmd2.ExecuteNonQuery();
            SqlCommand cmd3 = new SqlCommand("Update Student set LevelID =(select id from Level where level = '"+progress_level_to+"') where id = "+student_id, con);
            cmd3.ExecuteNonQuery();

            MessageBox.Show("Student have completed thier studies from their level.\nStudent have progress from "+student_level+" to "+progress_level_to, "Student Progressed",MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            return true;
        }

    }


}
