namespace Tuition_Centre_Management_System
{
    partial class AdminHomePage
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
            this.tabconprofile = new System.Windows.Forms.TabControl();
            this.tabprofile = new System.Windows.Forms.TabPage();
            this.lbladdresserror = new System.Windows.Forms.Label();
            this.lblemailerror = new System.Windows.Forms.Label();
            this.lblcontacterror = new System.Windows.Forms.Label();
            this.lblcpass = new System.Windows.Forms.Label();
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
            this.tabtutor = new System.Windows.Forms.TabPage();
            this.lblAddress_error_messsage = new System.Windows.Forms.Label();
            this.lblEmail_error_message = new System.Windows.Forms.Label();
            this.lblContact_error_message = new System.Windows.Forms.Label();
            this.lblName_error_message = new System.Windows.Forms.Label();
            this.lblUsername_error_message = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbTutorLevel = new System.Windows.Forms.ComboBox();
            this.lblStudent_Level = new System.Windows.Forms.Label();
            this.txtTutorUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.linklblassign = new System.Windows.Forms.LinkLabel();
            this.btnRegisterTutor = new System.Windows.Forms.Button();
            this.txtTutorAddress = new System.Windows.Forms.TextBox();
            this.txtTutorEmail = new System.Windows.Forms.TextBox();
            this.txtTutorContact = new System.Windows.Forms.TextBox();
            this.txtTutorName = new System.Windows.Forms.TextBox();
            this.lbltutAddress = new System.Windows.Forms.Label();
            this.lbltutEmail = new System.Windows.Forms.Label();
            this.lbltutContact = new System.Windows.Forms.Label();
            this.lbltutName = new System.Windows.Forms.Label();
            this.btnDeleteTutor = new System.Windows.Forms.Button();
            this.lstTutorID = new System.Windows.Forms.ListBox();
            this.tabreceptionist = new System.Windows.Forms.TabPage();
            this.btnAddRec = new System.Windows.Forms.Button();
            this.txtBoxrecAddress = new System.Windows.Forms.TextBox();
            this.txtBoxrecEmail = new System.Windows.Forms.TextBox();
            this.txtBoxrecContact = new System.Windows.Forms.TextBox();
            this.txtBoxrecName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteRec = new System.Windows.Forms.Button();
            this.listBoxrec = new System.Windows.Forms.ListBox();
            this.tabreport = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbltuitioname = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.tabconprofile.SuspendLayout();
            this.tabprofile.SuspendLayout();
            this.tabtutor.SuspendLayout();
            this.tabreceptionist.SuspendLayout();
            this.tabreport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabconprofile
            // 
            this.tabconprofile.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabconprofile.Controls.Add(this.tabprofile);
            this.tabconprofile.Controls.Add(this.tabtutor);
            this.tabconprofile.Controls.Add(this.tabreceptionist);
            this.tabconprofile.Controls.Add(this.tabreport);
            this.tabconprofile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabconprofile.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabconprofile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabconprofile.Location = new System.Drawing.Point(0, 98);
            this.tabconprofile.Multiline = true;
            this.tabconprofile.Name = "tabconprofile";
            this.tabconprofile.SelectedIndex = 0;
            this.tabconprofile.Size = new System.Drawing.Size(659, 288);
            this.tabconprofile.TabIndex = 4;
            // 
            // tabprofile
            // 
            this.tabprofile.Controls.Add(this.lbladdresserror);
            this.tabprofile.Controls.Add(this.lblemailerror);
            this.tabprofile.Controls.Add(this.lblcontacterror);
            this.tabprofile.Controls.Add(this.lblcpass);
            this.tabprofile.Controls.Add(this.btnupdateprofile);
            this.tabprofile.Controls.Add(this.btneditprofile);
            this.tabprofile.Controls.Add(this.lbladdress);
            this.tabprofile.Controls.Add(this.txtAddress);
            this.tabprofile.Controls.Add(this.txtemail);
            this.tabprofile.Controls.Add(this.txtcontact);
            this.tabprofile.Controls.Add(this.txtname);
            this.tabprofile.Controls.Add(this.lblemail);
            this.tabprofile.Controls.Add(this.lblcontact);
            this.tabprofile.Controls.Add(this.lblname);
            this.tabprofile.Location = new System.Drawing.Point(4, 30);
            this.tabprofile.Name = "tabprofile";
            this.tabprofile.Padding = new System.Windows.Forms.Padding(3);
            this.tabprofile.Size = new System.Drawing.Size(651, 254);
            this.tabprofile.TabIndex = 0;
            this.tabprofile.Text = "Profile";
            this.tabprofile.UseVisualStyleBackColor = true;
            // 
            // lbladdresserror
            // 
            this.lbladdresserror.AutoSize = true;
            this.lbladdresserror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbladdresserror.ForeColor = System.Drawing.Color.Red;
            this.lbladdresserror.Location = new System.Drawing.Point(381, 80);
            this.lbladdresserror.Name = "lbladdresserror";
            this.lbladdresserror.Size = new System.Drawing.Size(0, 16);
            this.lbladdresserror.TabIndex = 18;
            // 
            // lblemailerror
            // 
            this.lblemailerror.AutoSize = true;
            this.lblemailerror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblemailerror.ForeColor = System.Drawing.Color.Red;
            this.lblemailerror.Location = new System.Drawing.Point(57, 234);
            this.lblemailerror.Name = "lblemailerror";
            this.lblemailerror.Size = new System.Drawing.Size(0, 16);
            this.lblemailerror.TabIndex = 17;
            // 
            // lblcontacterror
            // 
            this.lblcontacterror.AutoSize = true;
            this.lblcontacterror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcontacterror.ForeColor = System.Drawing.Color.Red;
            this.lblcontacterror.Location = new System.Drawing.Point(57, 157);
            this.lblcontacterror.Name = "lblcontacterror";
            this.lblcontacterror.Size = new System.Drawing.Size(0, 16);
            this.lblcontacterror.TabIndex = 16;
            // 
            // lblcpass
            // 
            this.lblcpass.AutoSize = true;
            this.lblcpass.BackColor = System.Drawing.SystemColors.Control;
            this.lblcpass.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblcpass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblcpass.Location = new System.Drawing.Point(546, 232);
            this.lblcpass.Name = "lblcpass";
            this.lblcpass.Size = new System.Drawing.Size(104, 18);
            this.lblcpass.TabIndex = 15;
            this.lblcpass.Text = "Change Password";
            // 
            // btnupdateprofile
            // 
            this.btnupdateprofile.Location = new System.Drawing.Point(375, 168);
            this.btnupdateprofile.Name = "btnupdateprofile";
            this.btnupdateprofile.Size = new System.Drawing.Size(117, 30);
            this.btnupdateprofile.TabIndex = 14;
            this.btnupdateprofile.Text = "Update Profile";
            this.btnupdateprofile.UseVisualStyleBackColor = true;
            // 
            // btneditprofile
            // 
            this.btneditprofile.Location = new System.Drawing.Point(375, 118);
            this.btneditprofile.Name = "btneditprofile";
            this.btneditprofile.Size = new System.Drawing.Size(117, 30);
            this.btneditprofile.TabIndex = 13;
            this.btneditprofile.Text = "Edit Profile";
            this.btneditprofile.UseVisualStyleBackColor = true;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(381, 33);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(59, 18);
            this.lbladdress.TabIndex = 12;
            this.lbladdress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(375, 48);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(184, 23);
            this.txtAddress.TabIndex = 11;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Location = new System.Drawing.Point(52, 201);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(184, 23);
            this.txtemail.TabIndex = 7;
            // 
            // txtcontact
            // 
            this.txtcontact.BackColor = System.Drawing.Color.White;
            this.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontact.Location = new System.Drawing.Point(52, 125);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.ReadOnly = true;
            this.txtcontact.Size = new System.Drawing.Size(184, 23);
            this.txtcontact.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(52, 48);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(184, 23);
            this.txtname.TabIndex = 5;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(57, 186);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(43, 18);
            this.lblemail.TabIndex = 9;
            this.lblemail.Text = "Email";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(57, 110);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(58, 18);
            this.lblcontact.TabIndex = 3;
            this.lblcontact.Text = "Contact";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(57, 33);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 18);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            // 
            // tabtutor
            // 
            this.tabtutor.Controls.Add(this.lblAddress_error_messsage);
            this.tabtutor.Controls.Add(this.lblEmail_error_message);
            this.tabtutor.Controls.Add(this.lblContact_error_message);
            this.tabtutor.Controls.Add(this.lblName_error_message);
            this.tabtutor.Controls.Add(this.lblUsername_error_message);
            this.tabtutor.Controls.Add(this.btnClear);
            this.tabtutor.Controls.Add(this.cmbTutorLevel);
            this.tabtutor.Controls.Add(this.lblStudent_Level);
            this.tabtutor.Controls.Add(this.txtTutorUsername);
            this.tabtutor.Controls.Add(this.lblUsername);
            this.tabtutor.Controls.Add(this.linklblassign);
            this.tabtutor.Controls.Add(this.btnRegisterTutor);
            this.tabtutor.Controls.Add(this.txtTutorAddress);
            this.tabtutor.Controls.Add(this.txtTutorEmail);
            this.tabtutor.Controls.Add(this.txtTutorContact);
            this.tabtutor.Controls.Add(this.txtTutorName);
            this.tabtutor.Controls.Add(this.lbltutAddress);
            this.tabtutor.Controls.Add(this.lbltutEmail);
            this.tabtutor.Controls.Add(this.lbltutContact);
            this.tabtutor.Controls.Add(this.lbltutName);
            this.tabtutor.Controls.Add(this.btnDeleteTutor);
            this.tabtutor.Controls.Add(this.lstTutorID);
            this.tabtutor.Location = new System.Drawing.Point(4, 30);
            this.tabtutor.Name = "tabtutor";
            this.tabtutor.Padding = new System.Windows.Forms.Padding(3);
            this.tabtutor.Size = new System.Drawing.Size(651, 254);
            this.tabtutor.TabIndex = 1;
            this.tabtutor.Text = "Tutor";
            this.tabtutor.UseVisualStyleBackColor = true;
            // 
            // lblAddress_error_messsage
            // 
            this.lblAddress_error_messsage.AutoSize = true;
            this.lblAddress_error_messsage.Location = new System.Drawing.Point(481, 92);
            this.lblAddress_error_messsage.Name = "lblAddress_error_messsage";
            this.lblAddress_error_messsage.Size = new System.Drawing.Size(52, 18);
            this.lblAddress_error_messsage.TabIndex = 41;
            this.lblAddress_error_messsage.Text = "label10";
            // 
            // lblEmail_error_message
            // 
            this.lblEmail_error_message.AutoSize = true;
            this.lblEmail_error_message.Location = new System.Drawing.Point(481, 39);
            this.lblEmail_error_message.Name = "lblEmail_error_message";
            this.lblEmail_error_message.Size = new System.Drawing.Size(45, 18);
            this.lblEmail_error_message.TabIndex = 40;
            this.lblEmail_error_message.Text = "label9";
            // 
            // lblContact_error_message
            // 
            this.lblContact_error_message.AutoSize = true;
            this.lblContact_error_message.Location = new System.Drawing.Point(220, 145);
            this.lblContact_error_message.Name = "lblContact_error_message";
            this.lblContact_error_message.Size = new System.Drawing.Size(45, 18);
            this.lblContact_error_message.TabIndex = 39;
            this.lblContact_error_message.Text = "label8";
            // 
            // lblName_error_message
            // 
            this.lblName_error_message.AutoSize = true;
            this.lblName_error_message.Location = new System.Drawing.Point(220, 92);
            this.lblName_error_message.Name = "lblName_error_message";
            this.lblName_error_message.Size = new System.Drawing.Size(45, 18);
            this.lblName_error_message.TabIndex = 38;
            this.lblName_error_message.Text = "label7";
            // 
            // lblUsername_error_message
            // 
            this.lblUsername_error_message.AutoSize = true;
            this.lblUsername_error_message.Location = new System.Drawing.Point(220, 39);
            this.lblUsername_error_message.Name = "lblUsername_error_message";
            this.lblUsername_error_message.Size = new System.Drawing.Size(45, 18);
            this.lblUsername_error_message.TabIndex = 37;
            this.lblUsername_error_message.Text = "label6";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(292, 218);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 27);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbTutorLevel
            // 
            this.cmbTutorLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTutorLevel.FormattingEnabled = true;
            this.cmbTutorLevel.Items.AddRange(new object[] {
            "Form 1",
            "Form 2",
            "Form 3",
            "Form 4",
            "Form 5"});
            this.cmbTutorLevel.Location = new System.Drawing.Point(481, 117);
            this.cmbTutorLevel.Name = "cmbTutorLevel";
            this.cmbTutorLevel.Size = new System.Drawing.Size(77, 26);
            this.cmbTutorLevel.TabIndex = 35;
            // 
            // lblStudent_Level
            // 
            this.lblStudent_Level.AutoSize = true;
            this.lblStudent_Level.Location = new System.Drawing.Point(422, 123);
            this.lblStudent_Level.Name = "lblStudent_Level";
            this.lblStudent_Level.Size = new System.Drawing.Size(53, 18);
            this.lblStudent_Level.TabIndex = 34;
            this.lblStudent_Level.Text = "Level : ";
            // 
            // txtTutorUsername
            // 
            this.txtTutorUsername.Location = new System.Drawing.Point(220, 14);
            this.txtTutorUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTutorUsername.Name = "txtTutorUsername";
            this.txtTutorUsername.Size = new System.Drawing.Size(154, 23);
            this.txtTutorUsername.TabIndex = 13;
            this.txtTutorUsername.TextChanged += new System.EventHandler(this.txtTutorUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(130, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 18);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username : ";
            // 
            // linklblassign
            // 
            this.linklblassign.AutoSize = true;
            this.linklblassign.Location = new System.Drawing.Point(481, 227);
            this.linklblassign.Name = "linklblassign";
            this.linklblassign.Size = new System.Drawing.Size(164, 18);
            this.linklblassign.TabIndex = 11;
            this.linklblassign.TabStop = true;
            this.linklblassign.Text = "Assign Level and Subject";
            // 
            // btnRegisterTutor
            // 
            this.btnRegisterTutor.Enabled = false;
            this.btnRegisterTutor.Location = new System.Drawing.Point(386, 218);
            this.btnRegisterTutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterTutor.Name = "btnRegisterTutor";
            this.btnRegisterTutor.Size = new System.Drawing.Size(82, 27);
            this.btnRegisterTutor.TabIndex = 10;
            this.btnRegisterTutor.Text = "Register";
            this.btnRegisterTutor.UseVisualStyleBackColor = true;
            this.btnRegisterTutor.Click += new System.EventHandler(this.btnRegisterTutor_Click);
            // 
            // txtTutorAddress
            // 
            this.txtTutorAddress.Location = new System.Drawing.Point(481, 67);
            this.txtTutorAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTutorAddress.Name = "txtTutorAddress";
            this.txtTutorAddress.Size = new System.Drawing.Size(154, 23);
            this.txtTutorAddress.TabIndex = 9;
            this.txtTutorAddress.TextChanged += new System.EventHandler(this.txtTutorAddress_TextChanged);
            // 
            // txtTutorEmail
            // 
            this.txtTutorEmail.Location = new System.Drawing.Point(481, 14);
            this.txtTutorEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTutorEmail.Name = "txtTutorEmail";
            this.txtTutorEmail.Size = new System.Drawing.Size(154, 23);
            this.txtTutorEmail.TabIndex = 8;
            this.txtTutorEmail.TextChanged += new System.EventHandler(this.txtBoxtutEmail_TextChanged);
            // 
            // txtTutorContact
            // 
            this.txtTutorContact.Location = new System.Drawing.Point(220, 120);
            this.txtTutorContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTutorContact.Name = "txtTutorContact";
            this.txtTutorContact.Size = new System.Drawing.Size(154, 23);
            this.txtTutorContact.TabIndex = 7;
            this.txtTutorContact.TextChanged += new System.EventHandler(this.txtTutorContact_TextChanged);
            // 
            // txtTutorName
            // 
            this.txtTutorName.Location = new System.Drawing.Point(220, 67);
            this.txtTutorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTutorName.Name = "txtTutorName";
            this.txtTutorName.Size = new System.Drawing.Size(154, 23);
            this.txtTutorName.TabIndex = 6;
            this.txtTutorName.TextChanged += new System.EventHandler(this.txtTutorName_TextChanged);
            // 
            // lbltutAddress
            // 
            this.lbltutAddress.AutoSize = true;
            this.lbltutAddress.Location = new System.Drawing.Point(401, 72);
            this.lbltutAddress.Name = "lbltutAddress";
            this.lbltutAddress.Size = new System.Drawing.Size(67, 18);
            this.lbltutAddress.TabIndex = 5;
            this.lbltutAddress.Text = "Address :";
            // 
            // lbltutEmail
            // 
            this.lbltutEmail.AutoSize = true;
            this.lbltutEmail.Location = new System.Drawing.Point(417, 19);
            this.lbltutEmail.Name = "lbltutEmail";
            this.lbltutEmail.Size = new System.Drawing.Size(51, 18);
            this.lbltutEmail.TabIndex = 4;
            this.lbltutEmail.Text = "Email :";
            // 
            // lbltutContact
            // 
            this.lbltutContact.AutoSize = true;
            this.lbltutContact.Location = new System.Drawing.Point(143, 125);
            this.lbltutContact.Name = "lbltutContact";
            this.lbltutContact.Size = new System.Drawing.Size(66, 18);
            this.lbltutContact.TabIndex = 3;
            this.lbltutContact.Text = "Contact :";
            // 
            // lbltutName
            // 
            this.lbltutName.AutoSize = true;
            this.lbltutName.Location = new System.Drawing.Point(154, 72);
            this.lbltutName.Name = "lbltutName";
            this.lbltutName.Size = new System.Drawing.Size(53, 18);
            this.lbltutName.TabIndex = 2;
            this.lbltutName.Text = "Name :";
            // 
            // btnDeleteTutor
            // 
            this.btnDeleteTutor.Enabled = false;
            this.btnDeleteTutor.Location = new System.Drawing.Point(8, 225);
            this.btnDeleteTutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTutor.Name = "btnDeleteTutor";
            this.btnDeleteTutor.Size = new System.Drawing.Size(82, 22);
            this.btnDeleteTutor.TabIndex = 1;
            this.btnDeleteTutor.Text = "Delete";
            this.btnDeleteTutor.UseVisualStyleBackColor = true;
            this.btnDeleteTutor.Click += new System.EventHandler(this.btnDeleteTutor_Click);
            // 
            // lstTutorID
            // 
            this.lstTutorID.FormattingEnabled = true;
            this.lstTutorID.ItemHeight = 18;
            this.lstTutorID.Location = new System.Drawing.Point(8, 14);
            this.lstTutorID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstTutorID.Name = "lstTutorID";
            this.lstTutorID.Size = new System.Drawing.Size(113, 166);
            this.lstTutorID.TabIndex = 0;
            this.lstTutorID.SelectedIndexChanged += new System.EventHandler(this.lstTutorID_SelectedIndexChanged);
            // 
            // tabreceptionist
            // 
            this.tabreceptionist.Controls.Add(this.btnAddRec);
            this.tabreceptionist.Controls.Add(this.txtBoxrecAddress);
            this.tabreceptionist.Controls.Add(this.txtBoxrecEmail);
            this.tabreceptionist.Controls.Add(this.txtBoxrecContact);
            this.tabreceptionist.Controls.Add(this.txtBoxrecName);
            this.tabreceptionist.Controls.Add(this.label1);
            this.tabreceptionist.Controls.Add(this.label2);
            this.tabreceptionist.Controls.Add(this.label3);
            this.tabreceptionist.Controls.Add(this.label4);
            this.tabreceptionist.Controls.Add(this.btnDeleteRec);
            this.tabreceptionist.Controls.Add(this.listBoxrec);
            this.tabreceptionist.Location = new System.Drawing.Point(4, 30);
            this.tabreceptionist.Name = "tabreceptionist";
            this.tabreceptionist.Padding = new System.Windows.Forms.Padding(3);
            this.tabreceptionist.Size = new System.Drawing.Size(651, 254);
            this.tabreceptionist.TabIndex = 2;
            this.tabreceptionist.Text = "Receptionist";
            this.tabreceptionist.UseVisualStyleBackColor = true;
            // 
            // btnAddRec
            // 
            this.btnAddRec.Location = new System.Drawing.Point(444, 183);
            this.btnAddRec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRec.Name = "btnAddRec";
            this.btnAddRec.Size = new System.Drawing.Size(82, 22);
            this.btnAddRec.TabIndex = 21;
            this.btnAddRec.Text = "Add";
            this.btnAddRec.UseVisualStyleBackColor = true;
            // 
            // txtBoxrecAddress
            // 
            this.txtBoxrecAddress.Location = new System.Drawing.Point(458, 127);
            this.txtBoxrecAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxrecAddress.Name = "txtBoxrecAddress";
            this.txtBoxrecAddress.Size = new System.Drawing.Size(139, 23);
            this.txtBoxrecAddress.TabIndex = 20;
            // 
            // txtBoxrecEmail
            // 
            this.txtBoxrecEmail.Location = new System.Drawing.Point(444, 94);
            this.txtBoxrecEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxrecEmail.Name = "txtBoxrecEmail";
            this.txtBoxrecEmail.Size = new System.Drawing.Size(154, 23);
            this.txtBoxrecEmail.TabIndex = 19;
            // 
            // txtBoxrecContact
            // 
            this.txtBoxrecContact.Location = new System.Drawing.Point(458, 62);
            this.txtBoxrecContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxrecContact.Name = "txtBoxrecContact";
            this.txtBoxrecContact.Size = new System.Drawing.Size(139, 23);
            this.txtBoxrecContact.TabIndex = 18;
            // 
            // txtBoxrecName
            // 
            this.txtBoxrecName.Location = new System.Drawing.Point(444, 29);
            this.txtBoxrecName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxrecName.Name = "txtBoxrecName";
            this.txtBoxrecName.Size = new System.Drawing.Size(154, 23);
            this.txtBoxrecName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contact :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name :";
            // 
            // btnDeleteRec
            // 
            this.btnDeleteRec.Location = new System.Drawing.Point(162, 223);
            this.btnDeleteRec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteRec.Name = "btnDeleteRec";
            this.btnDeleteRec.Size = new System.Drawing.Size(82, 22);
            this.btnDeleteRec.TabIndex = 12;
            this.btnDeleteRec.Text = "Delete";
            this.btnDeleteRec.UseVisualStyleBackColor = true;
            // 
            // listBoxrec
            // 
            this.listBoxrec.FormattingEnabled = true;
            this.listBoxrec.ItemHeight = 18;
            this.listBoxrec.Location = new System.Drawing.Point(117, 29);
            this.listBoxrec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxrec.Name = "listBoxrec";
            this.listBoxrec.Size = new System.Drawing.Size(194, 166);
            this.listBoxrec.TabIndex = 11;
            // 
            // tabreport
            // 
            this.tabreport.Controls.Add(this.dataGridView1);
            this.tabreport.Controls.Add(this.label5);
            this.tabreport.Controls.Add(this.numericUpDown1);
            this.tabreport.Location = new System.Drawing.Point(4, 30);
            this.tabreport.Name = "tabreport";
            this.tabreport.Padding = new System.Windows.Forms.Padding(3);
            this.tabreport.Size = new System.Drawing.Size(651, 254);
            this.tabreport.TabIndex = 3;
            this.tabreport.Text = "Report";
            this.tabreport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 197);
            this.dataGridView1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Month :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(442, 28);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 23);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbltuitioname
            // 
            this.lbltuitioname.AutoSize = true;
            this.lbltuitioname.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltuitioname.ForeColor = System.Drawing.Color.White;
            this.lbltuitioname.Location = new System.Drawing.Point(362, 0);
            this.lbltuitioname.Name = "lbltuitioname";
            this.lbltuitioname.Size = new System.Drawing.Size(295, 23);
            this.lbltuitioname.TabIndex = 5;
            this.lbltuitioname.Text = "Excellent Tuition Centre";
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(24, 45);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(0, 30);
            this.lblwelcome.TabIndex = 6;
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(659, 386);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.lbltuitioname);
            this.Controls.Add(this.tabconprofile);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.tabconprofile.ResumeLayout(false);
            this.tabprofile.ResumeLayout(false);
            this.tabprofile.PerformLayout();
            this.tabtutor.ResumeLayout(false);
            this.tabtutor.PerformLayout();
            this.tabreceptionist.ResumeLayout(false);
            this.tabreceptionist.PerformLayout();
            this.tabreport.ResumeLayout(false);
            this.tabreport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabconprofile;
        private TabPage tabprofile;
        private Label lbladdresserror;
        private Label lblemailerror;
        private Label lblcontacterror;
        private Label lblcpass;
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
        private TabPage tabtutor;
        private LinkLabel linklblassign;
        private Button btnRegisterTutor;
        private TextBox txtTutorAddress;
        private TextBox txtTutorEmail;
        private TextBox txtTutorContact;
        private TextBox txtTutorName;
        private Label lbltutAddress;
        private Label lbltutEmail;
        private Label lbltutContact;
        private Label lbltutName;
        private Button btnDeleteTutor;
        private ListBox lstTutorID;
        private TabPage tabreceptionist;
        private Button btnAddRec;
        private TextBox txtBoxrecAddress;
        private TextBox txtBoxrecEmail;
        private TextBox txtBoxrecContact;
        private TextBox txtBoxrecName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDeleteRec;
        private ListBox listBoxrec;
        private TabPage tabreport;
        private DataGridView dataGridView1;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label lbltuitioname;
        private Label lblwelcome;
        private TextBox txtTutorUsername;
        private Label lblUsername;
        private ComboBox cmbTutorLevel;
        private Label lblStudent_Level;
        private Label lblAddress_error_messsage;
        private Label lblEmail_error_message;
        private Label lblContact_error_message;
        private Label lblName_error_message;
        private Label lblUsername_error_message;
        private Button btnClear;
    }
}