namespace Tuition_Centre_Management_System
{
    partial class TutorHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.lblcpass = new System.Windows.Forms.Label();
            this.txtlevel = new System.Windows.Forms.TextBox();
            this.lbllevel = new System.Windows.Forms.Label();
            this.lbladdresserror = new System.Windows.Forms.Label();
            this.lblemailerror = new System.Windows.Forms.Label();
            this.lblcontacterror = new System.Windows.Forms.Label();
            this.btnupdateprofile = new System.Windows.Forms.Button();
            this.btneditprofile = new System.Windows.Forms.Button();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.tabCreateClass = new System.Windows.Forms.TabPage();
            this.lblsubject_name_selected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblSubject_Name = new System.Windows.Forms.Label();
            this.lstTaught_subject_list = new System.Windows.Forms.ListBox();
            this.cmbWeekdays = new System.Windows.Forms.ComboBox();
            this.dtpEnd_Time = new System.Windows.Forms.DateTimePicker();
            this.dtpStart_Time = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lbltuitioname = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabCreateClass.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabProfile);
            this.tabControl1.Controls.Add(this.tabCreateClass);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.lblcpass);
            this.tabProfile.Controls.Add(this.txtlevel);
            this.tabProfile.Controls.Add(this.lbllevel);
            this.tabProfile.Controls.Add(this.lbladdresserror);
            this.tabProfile.Controls.Add(this.lblemailerror);
            this.tabProfile.Controls.Add(this.lblcontacterror);
            this.tabProfile.Controls.Add(this.btnupdateprofile);
            this.tabProfile.Controls.Add(this.btneditprofile);
            this.tabProfile.Controls.Add(this.lbladdress);
            this.tabProfile.Controls.Add(this.txtAddress);
            this.tabProfile.Controls.Add(this.txtemail);
            this.tabProfile.Controls.Add(this.txtcontact);
            this.tabProfile.Controls.Add(this.txtname);
            this.tabProfile.Controls.Add(this.lblemail);
            this.tabProfile.Controls.Add(this.lblcontact);
            this.tabProfile.Controls.Add(this.lblname);
            this.tabProfile.Location = new System.Drawing.Point(4, 30);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(651, 249);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // lblcpass
            // 
            this.lblcpass.AutoSize = true;
            this.lblcpass.BackColor = System.Drawing.SystemColors.Control;
            this.lblcpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcpass.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblcpass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblcpass.Location = new System.Drawing.Point(541, 226);
            this.lblcpass.Name = "lblcpass";
            this.lblcpass.Size = new System.Drawing.Size(104, 18);
            this.lblcpass.TabIndex = 34;
            this.lblcpass.Text = "Change Password";
            this.lblcpass.Click += new System.EventHandler(this.lblcpass_Click);
            // 
            // txtlevel
            // 
            this.txtlevel.BackColor = System.Drawing.Color.White;
            this.txtlevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlevel.Location = new System.Drawing.Point(375, 101);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.ReadOnly = true;
            this.txtlevel.Size = new System.Drawing.Size(184, 23);
            this.txtlevel.TabIndex = 33;
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Location = new System.Drawing.Point(375, 80);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(41, 18);
            this.lbllevel.TabIndex = 32;
            this.lbllevel.Text = "Level";
            // 
            // lbladdresserror
            // 
            this.lbladdresserror.AutoSize = true;
            this.lbladdresserror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbladdresserror.ForeColor = System.Drawing.Color.Red;
            this.lbladdresserror.Location = new System.Drawing.Point(395, 63);
            this.lbladdresserror.Name = "lbladdresserror";
            this.lbladdresserror.Size = new System.Drawing.Size(0, 16);
            this.lbladdresserror.TabIndex = 31;
            // 
            // lblemailerror
            // 
            this.lblemailerror.AutoSize = true;
            this.lblemailerror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblemailerror.ForeColor = System.Drawing.Color.Red;
            this.lblemailerror.Location = new System.Drawing.Point(72, 216);
            this.lblemailerror.Name = "lblemailerror";
            this.lblemailerror.Size = new System.Drawing.Size(0, 16);
            this.lblemailerror.TabIndex = 30;
            // 
            // lblcontacterror
            // 
            this.lblcontacterror.AutoSize = true;
            this.lblcontacterror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcontacterror.ForeColor = System.Drawing.Color.Red;
            this.lblcontacterror.Location = new System.Drawing.Point(72, 140);
            this.lblcontacterror.Name = "lblcontacterror";
            this.lblcontacterror.Size = new System.Drawing.Size(0, 16);
            this.lblcontacterror.TabIndex = 29;
            // 
            // btnupdateprofile
            // 
            this.btnupdateprofile.Location = new System.Drawing.Point(395, 206);
            this.btnupdateprofile.Name = "btnupdateprofile";
            this.btnupdateprofile.Size = new System.Drawing.Size(117, 30);
            this.btnupdateprofile.TabIndex = 28;
            this.btnupdateprofile.Text = "Update Profile";
            this.btnupdateprofile.UseVisualStyleBackColor = true;
            this.btnupdateprofile.Click += new System.EventHandler(this.btnupdateprofile_Click);
            // 
            // btneditprofile
            // 
            this.btneditprofile.Location = new System.Drawing.Point(395, 156);
            this.btneditprofile.Name = "btneditprofile";
            this.btneditprofile.Size = new System.Drawing.Size(117, 30);
            this.btneditprofile.TabIndex = 27;
            this.btneditprofile.Text = "Edit Profile";
            this.btneditprofile.UseVisualStyleBackColor = true;
            this.btneditprofile.Click += new System.EventHandler(this.btneditprofile_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(375, 3);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(59, 18);
            this.lbladdress.TabIndex = 26;
            this.lbladdress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(375, 24);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(184, 23);
            this.txtAddress.TabIndex = 25;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Location = new System.Drawing.Point(52, 177);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(184, 23);
            this.txtemail.TabIndex = 23;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtcontact
            // 
            this.txtcontact.BackColor = System.Drawing.Color.White;
            this.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontact.Location = new System.Drawing.Point(52, 101);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.ReadOnly = true;
            this.txtcontact.Size = new System.Drawing.Size(184, 23);
            this.txtcontact.TabIndex = 22;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(52, 24);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(184, 23);
            this.txtname.TabIndex = 21;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(52, 156);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(43, 18);
            this.lblemail.TabIndex = 24;
            this.lblemail.Text = "Email";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(52, 80);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(58, 18);
            this.lblcontact.TabIndex = 20;
            this.lblcontact.Text = "Contact";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(52, 3);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 18);
            this.lblname.TabIndex = 19;
            this.lblname.Text = "Name";
            // 
            // tabCreateClass
            // 
            this.tabCreateClass.Controls.Add(this.lblsubject_name_selected);
            this.tabCreateClass.Controls.Add(this.label1);
            this.tabCreateClass.Controls.Add(this.button2);
            this.tabCreateClass.Controls.Add(this.btnCreate);
            this.tabCreateClass.Controls.Add(this.lblSubject_Name);
            this.tabCreateClass.Controls.Add(this.lstTaught_subject_list);
            this.tabCreateClass.Controls.Add(this.cmbWeekdays);
            this.tabCreateClass.Controls.Add(this.dtpEnd_Time);
            this.tabCreateClass.Controls.Add(this.dtpStart_Time);
            this.tabCreateClass.Location = new System.Drawing.Point(4, 30);
            this.tabCreateClass.Name = "tabCreateClass";
            this.tabCreateClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateClass.Size = new System.Drawing.Size(651, 249);
            this.tabCreateClass.TabIndex = 1;
            this.tabCreateClass.Text = "Create Class";
            this.tabCreateClass.UseVisualStyleBackColor = true;
            // 
            // lblsubject_name_selected
            // 
            this.lblsubject_name_selected.AutoSize = true;
            this.lblsubject_name_selected.Location = new System.Drawing.Point(330, 6);
            this.lblsubject_name_selected.Name = "lblsubject_name_selected";
            this.lblsubject_name_selected.Size = new System.Drawing.Size(45, 18);
            this.lblsubject_name_selected.TabIndex = 8;
            this.lblsubject_name_selected.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(546, 218);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblSubject_Name
            // 
            this.lblSubject_Name.AutoSize = true;
            this.lblSubject_Name.Location = new System.Drawing.Point(216, 6);
            this.lblSubject_Name.Name = "lblSubject_Name";
            this.lblSubject_Name.Size = new System.Drawing.Size(108, 18);
            this.lblSubject_Name.TabIndex = 4;
            this.lblSubject_Name.Text = "Subject Name : ";
            // 
            // lstTaught_subject_list
            // 
            this.lstTaught_subject_list.FormattingEnabled = true;
            this.lstTaught_subject_list.ItemHeight = 18;
            this.lstTaught_subject_list.Location = new System.Drawing.Point(8, 31);
            this.lstTaught_subject_list.Name = "lstTaught_subject_list";
            this.lstTaught_subject_list.Size = new System.Drawing.Size(120, 94);
            this.lstTaught_subject_list.TabIndex = 3;
            this.lstTaught_subject_list.SelectedIndexChanged += new System.EventHandler(this.lstTaught_subject_list_SelectedIndexChanged);
            // 
            // cmbWeekdays
            // 
            this.cmbWeekdays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeekdays.FormattingEnabled = true;
            this.cmbWeekdays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cmbWeekdays.Location = new System.Drawing.Point(216, 131);
            this.cmbWeekdays.Name = "cmbWeekdays";
            this.cmbWeekdays.Size = new System.Drawing.Size(133, 26);
            this.cmbWeekdays.TabIndex = 2;
            // 
            // dtpEnd_Time
            // 
            this.dtpEnd_Time.CustomFormat = "hh:mm tt";
            this.dtpEnd_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd_Time.Location = new System.Drawing.Point(400, 59);
            this.dtpEnd_Time.Name = "dtpEnd_Time";
            this.dtpEnd_Time.ShowUpDown = true;
            this.dtpEnd_Time.Size = new System.Drawing.Size(133, 23);
            this.dtpEnd_Time.TabIndex = 1;
            this.dtpEnd_Time.Value = new System.DateTime(2023, 2, 19, 11, 0, 0, 0);
            // 
            // dtpStart_Time
            // 
            this.dtpStart_Time.CustomFormat = "hh:mm tt";
            this.dtpStart_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart_Time.Location = new System.Drawing.Point(216, 59);
            this.dtpStart_Time.Name = "dtpStart_Time";
            this.dtpStart_Time.ShowUpDown = true;
            this.dtpStart_Time.Size = new System.Drawing.Size(133, 23);
            this.dtpStart_Time.TabIndex = 0;
            this.dtpStart_Time.Value = new System.DateTime(2023, 2, 19, 10, 0, 0, 0);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 249);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Update/Delete Class";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 249);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "View Student List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(24, 45);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(0, 30);
            this.lblwelcome.TabIndex = 2;
            // 
            // lbltuitioname
            // 
            this.lbltuitioname.AutoSize = true;
            this.lbltuitioname.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltuitioname.ForeColor = System.Drawing.Color.White;
            this.lbltuitioname.Location = new System.Drawing.Point(362, 0);
            this.lbltuitioname.Name = "lbltuitioname";
            this.lbltuitioname.Size = new System.Drawing.Size(295, 23);
            this.lbltuitioname.TabIndex = 3;
            this.lbltuitioname.Text = "Excellent Tuition Centre";
            // 
            // TutorHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(659, 386);
            this.Controls.Add(this.lbltuitioname);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TutorHomePage";
            this.Text = "TutorHomePage";
            this.Load += new System.EventHandler(this.TutorHomePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.tabCreateClass.ResumeLayout(false);
            this.tabCreateClass.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProfile;
        private TabPage tabCreateClass;
        private Label lblwelcome;
        private Label lbltuitioname;
        private Label lbladdresserror;
        private Label lblemailerror;
        private Label lblcontacterror;
        private Button btnupdateprofile;
        private Button btneditprofile;
        private Label lbladdress;
        private TextBox txtAddress;
        private TextBox txtemail;
        private TextBox txtcontact;
        private TextBox txtname;
        private Label lblemail;
        private Label lblcontact;
        private Label lblname;
        private TextBox txtlevel;
        private Label lbllevel;
        private Label lblcpass;
        private DateTimePicker dtpStart_Time;
        private Label lblSubject_Name;
        private ListBox lstTaught_subject_list;
        private ComboBox cmbWeekdays;
        private DateTimePicker dtpEnd_Time;
        private TabPage tabPage1;
        private Button button2;
        private Button btnCreate;
        private TabPage tabPage2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label1;
        private Label lblsubject_name_selected;
    }
}