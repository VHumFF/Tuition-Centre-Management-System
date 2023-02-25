using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Tuition_Centre_Management_System
{
    internal class Student
    {
        private string username;
        private int class_id;
        private int current_subject_id;
        private int change_to_subject_id;
        private int request_id;
        private int subject_id;
        private int payment_id;
        private int receipt_id;

        public Student(string un)
        {
            username = un;
        }
        public Student(int id)
        {
            class_id= id;
            request_id = id;
            payment_id = id;
            receipt_id = id;
        }

        public Student(int sub_id, string un)
        {
            subject_id= sub_id;
            username = un;

        }
        
        public Student(string un, int current_sub_id, int change_to_sub_id)
        {
            username = un;
            current_subject_id= current_sub_id;
            change_to_subject_id= change_to_sub_id;
        }

        public ArrayList get_enrolled_subject()
        {
            //get list of subject student enrolled in
            ArrayList sub_list = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select subjectid from enroll where studentid = (select id from student where userid = (select id from users where username = '"+username+"'))", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sub_list.Add(reader.GetInt32(0));
            }
            con.Close();
            return sub_list;
        }
        public ArrayList get_subject_change_list()
        {
            //get list of subject student can change to
            ArrayList sub_list = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select id from subject where levelid = (select levelid from student where Userid = (select id from users where username = '"+username+"'))", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sub_list.Add(reader.GetInt32(0));
            }
            con.Close();
            return sub_list;
        }

        public Tuple<string, string, string> get_class_schedule()
        {
            //get class schedule infomation
            string stime = "", etime = "", day = "";
            string start_time = "", end_time = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select weekday, starttime, endtime from class where id = " + class_id, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                day = reader["weekday"].ToString();
                stime = reader["starttime"].ToString();
                etime = reader["endtime"].ToString();

                start_time = DateTime.Parse(stime, System.Globalization.CultureInfo.CurrentCulture).ToString("hh:mm tt");
                end_time = DateTime.Parse(etime, System.Globalization.CultureInfo.CurrentCulture).ToString("hh:mm tt"); ;
            }

            var student_info = Tuple.Create(day, start_time, end_time);
            con.Close();
            return student_info;
        }


        public void request_sub_change()
        {
            //submit subject change request
            string progress = "";
            bool submit_request = true;
            bool check_ticket_exist = check_request_ticket(username, current_subject_id, change_to_subject_id);
            //check if student already have a request in pending if no, proceed
            if (!check_ticket_exist)
            {
                
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                con.Open();
                //check whether student select to change a subject that is already completed
                SqlCommand cmd = new SqlCommand("select progress from enroll where studentid = (select id from student where userid = (select id from users where username = '"+username+"')) and subjectid = "+current_subject_id, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    progress = reader.GetString(0);

                    if(progress == "Completed")
                    {
                        //do not allow student to change subject if already completed the subject
                        MessageBox.Show("Cannot change a completed subject", "Request Subject Channge", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        submit_request = false;
                    }
                }

                reader.Close();

                if (submit_request)
                {
                    //insert subject change request info to database
                    SqlCommand cmd2 = new SqlCommand("insert into request(StudentID, CurrentSubjectID, NewSubjectID) values((select id from student where userid = (select id from users where username = '" + username + "')), " + current_subject_id + "," + change_to_subject_id + ")", con);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("Update enroll set progress = 'Subject change pending' where subjectid = " + current_subject_id + " and studentid = (select id from student where userid = (select id from users where username = '" + username + "'))", con);

                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Request to change subject have sent to receptionist");
                   
                }
                con.Close();
                
            }
            
        }

        private bool check_request_ticket(string u_name, int c_sub, int n_sub)
        {
            //check whether student already have a request ticket in pending
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from request where studentid = (select id from student where userid = (select id from users where username = '"+u_name+"')) and currentsubjectid = "+c_sub, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("You already sent a request to change this subject", "Request Submission", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return true;
            }

            reader.Close();
            SqlCommand cmd2 = new SqlCommand("select * from request where studentid = (select id from student where userid = (select id from users where username = '" + u_name + "')) and newsubjectid = " + n_sub, con);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                MessageBox.Show("You already sent a request to change to this subject", "Request Submission", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return true;
            }

            con.Close();
            return false;
        }

        public Tuple<int, string, string> get_requset_info()
        {
            //return request infomation

            string c_sub_id = "";
            string n_sub_id = "";
            string c_sub_name = "";
            string n_sub_name = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //get request information
            SqlCommand cmd2 = new SqlCommand("select currentsubjectid, newsubjectid from request where id = " + request_id, con);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                c_sub_id = reader2["currentsubjectid"].ToString();
                n_sub_id = reader2["newsubjectid"].ToString();

                Tutor obj = new Tutor(Convert.ToInt32(c_sub_id));
                c_sub_name = obj.get_subject_name();
                Tutor obj2 = new Tutor(Convert.ToInt32(n_sub_id));
                n_sub_name = obj2.get_subject_name();
            }

            var request_info = Tuple.Create(request_id, c_sub_name, n_sub_name);

            con.Close();
            return request_info;

        }

        public void withdraw_request()
        {
            //cancel subject change request
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("update enroll set progress = 'In Progress' where subjectid = " +
                "(select currentsubjectid from request where id = " + request_id + ") and studentid = " +
                "(select studentid from request where id = " + request_id + ")", con);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("delete from request where id = "+request_id, con);
            cmd2.ExecuteNonQuery();
            con.Close();
            
        }

        public string get_subject_progress()
        {
            //get progress of enrolled subject
            string progress = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select progress from enroll where subjectid = "+subject_id+" and studentid = (select id from student where userid = (select id from users where username = '"+username+"'))", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                progress = reader["progress"].ToString();
            }

            con.Close();
            return progress;
        }

        public void complete_subject_studies()
        {
            //change enrolled subject progress to complete
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("update enroll set progress = 'Completed' where subjectid = " + subject_id + " and studentid = (select id from student where userid = (select id from users where username = '" + username + "'))", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Progress status of the subject have change to Completed", "Subject Studies Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        public ArrayList get_unpaid_fee_list()
        {
            //get list of unpaid fee id
            ArrayList payment_id_list = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select id from payment where studentid = (select id from student where userid = (select id from users where username = '"+username+"')) and status = 'unpaid'",con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                payment_id_list.Add(reader.GetInt32(0));
            }
            con.Close();
            return payment_id_list;
        }


        public decimal get_unpaid_fee_info()
        {
            //get outstand of unpaid fee
            decimal amount = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();


            SqlCommand cmd = new SqlCommand("select outstanding from payment where id = "+payment_id, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                amount = Convert.ToDecimal(reader["outstanding"]);
            }

            con.Close();
            return amount;
        }

        public void pay_unpaid_fee()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("Update payment set status = 'paid' where id = "+payment_id, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("You have pay the outstanding amount", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        public ArrayList get_receipt()
        {
            //get list of receitp of the student
            ArrayList receipt_id = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select id from receipt where studentid = (select id from student where userid = (select id from users where username = '"+username+"'))", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                receipt_id.Add(reader.GetInt32(0));
            }

            con.Close();
            return receipt_id;
        }

        public Tuple<string, decimal> get_receipt_info()
        {
            //get receipt information
            string date = "";
            string p_date = "";
            decimal amount = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select date, amount from receipt where id = "+receipt_id, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                date = reader["date"].ToString();
                amount = Convert.ToDecimal(reader["amount"]);

                p_date = DateTime.Parse(date, System.Globalization.CultureInfo.CurrentCulture).ToString("dd-MM-yyyy");
            }
            var receipt_info = Tuple.Create(p_date, amount);
            con.Close();
            return receipt_info;
        }


        public ArrayList get_request_id_list()
        {
            //get list of subject student enrolled in
            ArrayList r_id_list = new ArrayList();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select id from request where studentid = (select id from student where userid = (select id from users where username = '" + username + "'))", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                r_id_list.Add(reader.GetInt32(0));
            }
            con.Close();
            return r_id_list;
        }


    }


}
