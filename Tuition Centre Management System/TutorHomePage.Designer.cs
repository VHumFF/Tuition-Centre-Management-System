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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblSubject_Name = new System.Windows.Forms.Label();
            this.lstTaught_subject_list = new System.Windows.Forms.ListBox();
            this.cmbWeekdays = new System.Windows.Forms.ComboBox();
            this.dtpEnd_Time = new System.Windows.Forms.DateTimePicker();
            this.dtpStart_Time = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblsubject_name_selected1 = new System.Windows.Forms.Label();
            this.lblsubject_name1 = new System.Windows.Forms.Label();
            this.cmbWeekday2 = new System.Windows.Forms.ComboBox();
            this.dtpEnd_time2 = new System.Windows.Forms.DateTimePicker();
            this.dtpStart_time2 = new System.Windows.Forms.DateTimePicker();
            this.lstsubject_list = new System.Windows.Forms.ListBox();
            this.lstClass_list = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstSubject_list3 = new System.Windows.Forms.ListBox();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lbltuitioname = new System.Windows.Forms.Label();
            this.lblSubject_name_selected3 = new System.Windows.Forms.Label();
            this.lblSubject_name3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabCreateClass.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
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
            this.lblsubject_name_selected.Size = new System.Drawing.Size(0, 18);
            this.lblsubject_name_selected.TabIndex = 8;
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
            this.tabPage1.Controls.Add(this.lblsubject_name_selected1);
            this.tabPage1.Controls.Add(this.lblsubject_name1);
            this.tabPage1.Controls.Add(this.cmbWeekday2);
            this.tabPage1.Controls.Add(this.dtpEnd_time2);
            this.tabPage1.Controls.Add(this.dtpStart_time2);
            this.tabPage1.Controls.Add(this.lstsubject_list);
            this.tabPage1.Controls.Add(this.lstClass_list);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 249);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Update/Delete Class";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblsubject_name_selected1
            // 
            this.lblsubject_name_selected1.AutoSize = true;
            this.lblsubject_name_selected1.Location = new System.Drawing.Point(432, 17);
            this.lblsubject_name_selected1.Name = "lblsubject_name_selected1";
            this.lblsubject_name_selected1.Size = new System.Drawing.Size(45, 18);
            this.lblsubject_name_selected1.TabIndex = 13;
            this.lblsubject_name_selected1.Text = "label2";
            // 
            // lblsubject_name1
            // 
            this.lblsubject_name1.AutoSize = true;
            this.lblsubject_name1.Location = new System.Drawing.Point(318, 17);
            this.lblsubject_name1.Name = "lblsubject_name1";
            this.lblsubject_name1.Size = new System.Drawing.Size(108, 18);
            this.lblsubject_name1.TabIndex = 12;
            this.lblsubject_name1.Text = "Subject Name : ";
            // 
            // cmbWeekday2
            // 
            this.cmbWeekday2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeekday2.Enabled = false;
            this.cmbWeekday2.FormattingEnabled = true;
            this.cmbWeekday2.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cmbWeekday2.Location = new System.Drawing.Point(318, 142);
            this.cmbWeekday2.Name = "cmbWeekday2";
            this.cmbWeekday2.Size = new System.Drawing.Size(133, 26);
            this.cmbWeekday2.TabIndex = 11;
            // 
            // dtpEnd_time2
            // 
            this.dtpEnd_time2.CustomFormat = "hh:mm tt";
            this.dtpEnd_time2.Enabled = false;
            this.dtpEnd_time2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd_time2.Location = new System.Drawing.Point(502, 70);
            this.dtpEnd_time2.Name = "dtpEnd_time2";
            this.dtpEnd_time2.ShowUpDown = true;
            this.dtpEnd_time2.Size = new System.Drawing.Size(133, 23);
            this.dtpEnd_time2.TabIndex = 10;
            this.dtpEnd_time2.Value = new System.DateTime(2023, 2, 19, 11, 0, 0, 0);
            // 
            // dtpStart_time2
            // 
            this.dtpStart_time2.CustomFormat = "hh:mm tt";
            this.dtpStart_time2.Enabled = false;
            this.dtpStart_time2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart_time2.Location = new System.Drawing.Point(318, 70);
            this.dtpStart_time2.Name = "dtpStart_time2";
            this.dtpStart_time2.ShowUpDown = true;
            this.dtpStart_time2.Size = new System.Drawing.Size(133, 23);
            this.dtpStart_time2.TabIndex = 9;
            this.dtpStart_time2.Value = new System.DateTime(2023, 2, 19, 10, 0, 0, 0);
            // 
            // lstsubject_list
            // 
            this.lstsubject_list.FormattingEnabled = true;
            this.lstsubject_list.ItemHeight = 18;
            this.lstsubject_list.Location = new System.Drawing.Point(6, 17);
            this.lstsubject_list.Name = "lstsubject_list";
            this.lstsubject_list.Size = new System.Drawing.Size(120, 94);
            this.lstsubject_list.TabIndex = 4;
            this.lstsubject_list.SelectedIndexChanged += new System.EventHandler(this.lstsubject_list_SelectedIndexChanged);
            // 
            // lstClass_list
            // 
            this.lstClass_list.FormattingEnabled = true;
            this.lstClass_list.ItemHeight = 18;
            this.lstClass_list.Location = new System.Drawing.Point(151, 17);
            this.lstClass_list.Name = "lstClass_list";
            this.lstClass_list.Size = new System.Drawing.Size(120, 94);
            this.lstClass_list.TabIndex = 3;
            this.lstClass_list.SelectedIndexChanged += new System.EventHandler(this.lstClass_list_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(560, 189);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(560, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(8, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSubject_name_selected3);
            this.tabPage2.Controls.Add(this.lblSubject_name3);
            this.tabPage2.Controls.Add(this.dgvStudentList);
            this.tabPage2.Controls.Add(this.lstSubject_list3);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 249);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "View Student List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.SName,
            this.sEmail,
            this.sContact,
            this.sAddress});
            this.dgvStudentList.Location = new System.Drawing.Point(146, 46);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.RowTemplate.Height = 25;
            this.dgvStudentList.Size = new System.Drawing.Size(497, 195);
            this.dgvStudentList.TabIndex = 1;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            // 
            // SName
            // 
            this.SName.HeaderText = "Student Name";
            this.SName.Name = "SName";
            // 
            // sEmail
            // 
            this.sEmail.HeaderText = "Email";
            this.sEmail.Name = "sEmail";
            // 
            // sContact
            // 
            this.sContact.HeaderText = "Contact";
            this.sContact.Name = "sContact";
            // 
            // sAddress
            // 
            this.sAddress.HeaderText = "Address";
            this.sAddress.Name = "sAddress";
            // 
            // lstSubject_list3
            // 
            this.lstSubject_list3.FormattingEnabled = true;
            this.lstSubject_list3.ItemHeight = 18;
            this.lstSubject_list3.Location = new System.Drawing.Point(8, 46);
            this.lstSubject_list3.Name = "lstSubject_list3";
            this.lstSubject_list3.Size = new System.Drawing.Size(120, 130);
            this.lstSubject_list3.TabIndex = 0;
            this.lstSubject_list3.SelectedIndexChanged += new System.EventHandler(this.lstSubject_list3_SelectedIndexChanged);
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
            // lblSubject_name_selected3
            // 
            this.lblSubject_name_selected3.AutoSize = true;
            this.lblSubject_name_selected3.Location = new System.Drawing.Point(122, 13);
            this.lblSubject_name_selected3.Name = "lblSubject_name_selected3";
            this.lblSubject_name_selected3.Size = new System.Drawing.Size(45, 18);
            this.lblSubject_name_selected3.TabIndex = 15;
            this.lblSubject_name_selected3.Text = "label2";
            // 
            // lblSubject_name3
            // 
            this.lblSubject_name3.AutoSize = true;
            this.lblSubject_name3.Location = new System.Drawing.Point(8, 13);
            this.lblSubject_name3.Name = "lblSubject_name3";
            this.lblSubject_name3.Size = new System.Drawing.Size(108, 18);
            this.lblSubject_name3.TabIndex = 14;
            this.lblSubject_name3.Text = "Subject Name : ";
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
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
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
        private Button btnCreate;
        private TabPage tabPage2;
        private Button btnEdit;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private Label lblsubject_name_selected;
        private ListBox lstClass_list;
        private ListBox lstsubject_list;
        private Label lblsubject_name_selected1;
        private Label lblsubject_name1;
        private ComboBox cmbWeekday2;
        private DateTimePicker dtpEnd_time2;
        private DateTimePicker dtpStart_time2;
        private DataGridView dgvStudentList;
        private ListBox lstSubject_list3;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn SName;
        private DataGridViewTextBoxColumn sEmail;
        private DataGridViewTextBoxColumn sContact;
        private DataGridViewTextBoxColumn sAddress;
        private Label lblSubject_name_selected3;
        private Label lblSubject_name3;
    }
}