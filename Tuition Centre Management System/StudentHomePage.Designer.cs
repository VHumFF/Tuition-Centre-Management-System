namespace Tuition_Centre_Management_System
{
    partial class StudentHomePage
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
            this.lbltuitioname = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.tabRequest = new System.Windows.Forms.TabPage();
            this.lblChange_sub_name = new System.Windows.Forms.Label();
            this.lblcurrent_sub_name = new System.Windows.Forms.Label();
            this.lblSub_name = new System.Windows.Forms.Label();
            this.lblSub_name1 = new System.Windows.Forms.Label();
            this.lblsublist2 = new System.Windows.Forms.Label();
            this.lblsublist = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.lstchange_Sub_list = new System.Windows.Forms.ListBox();
            this.lstcurrent_erolled_sub = new System.Windows.Forms.ListBox();
            this.tabView_schedule = new System.Windows.Forms.TabPage();
            this.dgvClass_Shedule = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Start_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_End_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubject_name_selected = new System.Windows.Forms.Label();
            this.lblSubject_name = new System.Windows.Forms.Label();
            this.lstSubject_list = new System.Windows.Forms.ListBox();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.lblcpass = new System.Windows.Forms.Label();
            this.txtlevel = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbllevel = new System.Windows.Forms.Label();
            this.lbladdresserror = new System.Windows.Forms.Label();
            this.lblemailerror = new System.Windows.Forms.Label();
            this.lblcontacterror = new System.Windows.Forms.Label();
            this.btnupdateprofile = new System.Windows.Forms.Button();
            this.btneditprofile = new System.Windows.Forms.Button();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.tabcon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblNew_Sub = new System.Windows.Forms.Label();
            this.lblCurrent_sub1 = new System.Windows.Forms.Label();
            this.lblRequestid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblChange_sub_to = new System.Windows.Forms.Label();
            this.lblCurrent_sub = new System.Windows.Forms.Label();
            this.tabUpdateStudies = new System.Windows.Forms.TabPage();
            this.lblSub_progress = new System.Windows.Forms.Label();
            this.lblSubject_progress = new System.Windows.Forms.Label();
            this.lblSubject_name4 = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblSubject_name3 = new System.Windows.Forms.Label();
            this.lstSubject_enrolled_list = new System.Windows.Forms.ListBox();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.btnViewReceipt = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lstReceipt = new System.Windows.Forms.ListBox();
            this.lstUnpaidfee = new System.Windows.Forms.ListBox();
            this.lblList_of_sub_enrolled = new System.Windows.Forms.Label();
            this.lblList_of_unpaid_fee = new System.Windows.Forms.Label();
            this.lblList_of_receipt = new System.Windows.Forms.Label();
            this.tabRequest.SuspendLayout();
            this.tabView_schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass_Shedule)).BeginInit();
            this.tabProfile.SuspendLayout();
            this.tabcon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabUpdateStudies.SuspendLayout();
            this.tabPayment.SuspendLayout();
            this.SuspendLayout();
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
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(24, 45);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(0, 30);
            this.lblwelcome.TabIndex = 4;
            // 
            // tabRequest
            // 
            this.tabRequest.Controls.Add(this.lblChange_sub_name);
            this.tabRequest.Controls.Add(this.lblcurrent_sub_name);
            this.tabRequest.Controls.Add(this.lblSub_name);
            this.tabRequest.Controls.Add(this.lblSub_name1);
            this.tabRequest.Controls.Add(this.lblsublist2);
            this.tabRequest.Controls.Add(this.lblsublist);
            this.tabRequest.Controls.Add(this.btnRequest);
            this.tabRequest.Controls.Add(this.lstchange_Sub_list);
            this.tabRequest.Controls.Add(this.lstcurrent_erolled_sub);
            this.tabRequest.Location = new System.Drawing.Point(4, 30);
            this.tabRequest.Name = "tabRequest";
            this.tabRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequest.Size = new System.Drawing.Size(682, 249);
            this.tabRequest.TabIndex = 2;
            this.tabRequest.Text = "Request Subject Change";
            this.tabRequest.UseVisualStyleBackColor = true;
            // 
            // lblChange_sub_name
            // 
            this.lblChange_sub_name.AutoSize = true;
            this.lblChange_sub_name.Location = new System.Drawing.Point(448, 53);
            this.lblChange_sub_name.Name = "lblChange_sub_name";
            this.lblChange_sub_name.Size = new System.Drawing.Size(0, 18);
            this.lblChange_sub_name.TabIndex = 8;
            // 
            // lblcurrent_sub_name
            // 
            this.lblcurrent_sub_name.AutoSize = true;
            this.lblcurrent_sub_name.Location = new System.Drawing.Point(134, 53);
            this.lblcurrent_sub_name.Name = "lblcurrent_sub_name";
            this.lblcurrent_sub_name.Size = new System.Drawing.Size(0, 18);
            this.lblcurrent_sub_name.TabIndex = 7;
            // 
            // lblSub_name
            // 
            this.lblSub_name.AutoSize = true;
            this.lblSub_name.Location = new System.Drawing.Point(448, 24);
            this.lblSub_name.Name = "lblSub_name";
            this.lblSub_name.Size = new System.Drawing.Size(104, 18);
            this.lblSub_name.TabIndex = 6;
            this.lblSub_name.Text = "Subject Name :";
            // 
            // lblSub_name1
            // 
            this.lblSub_name1.AutoSize = true;
            this.lblSub_name1.Location = new System.Drawing.Point(134, 24);
            this.lblSub_name1.Name = "lblSub_name1";
            this.lblSub_name1.Size = new System.Drawing.Size(104, 18);
            this.lblSub_name1.TabIndex = 5;
            this.lblSub_name1.Text = "Subject Name :";
            // 
            // lblsublist2
            // 
            this.lblsublist2.AutoSize = true;
            this.lblsublist2.Location = new System.Drawing.Point(322, 3);
            this.lblsublist2.Name = "lblsublist2";
            this.lblsublist2.Size = new System.Drawing.Size(82, 18);
            this.lblsublist2.TabIndex = 4;
            this.lblsublist2.Text = "Subject List";
            // 
            // lblsublist
            // 
            this.lblsublist.AutoSize = true;
            this.lblsublist.Location = new System.Drawing.Point(8, 3);
            this.lblsublist.Name = "lblsublist";
            this.lblsublist.Size = new System.Drawing.Size(166, 18);
            this.lblsublist.TabIndex = 3;
            this.lblsublist.Text = "Current Enrolled Subject";
            // 
            // btnRequest
            // 
            this.btnRequest.Enabled = false;
            this.btnRequest.Location = new System.Drawing.Point(288, 218);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lstchange_Sub_list
            // 
            this.lstchange_Sub_list.FormattingEnabled = true;
            this.lstchange_Sub_list.ItemHeight = 18;
            this.lstchange_Sub_list.Location = new System.Drawing.Point(322, 24);
            this.lstchange_Sub_list.Name = "lstchange_Sub_list";
            this.lstchange_Sub_list.Size = new System.Drawing.Size(120, 94);
            this.lstchange_Sub_list.TabIndex = 1;
            this.lstchange_Sub_list.SelectedIndexChanged += new System.EventHandler(this.lstchange_Sub_list_SelectedIndexChanged);
            // 
            // lstcurrent_erolled_sub
            // 
            this.lstcurrent_erolled_sub.FormattingEnabled = true;
            this.lstcurrent_erolled_sub.ItemHeight = 18;
            this.lstcurrent_erolled_sub.Location = new System.Drawing.Point(8, 24);
            this.lstcurrent_erolled_sub.Name = "lstcurrent_erolled_sub";
            this.lstcurrent_erolled_sub.Size = new System.Drawing.Size(120, 94);
            this.lstcurrent_erolled_sub.TabIndex = 0;
            this.lstcurrent_erolled_sub.SelectedIndexChanged += new System.EventHandler(this.lstcurrent_erolled_sub_SelectedIndexChanged);
            // 
            // tabView_schedule
            // 
            this.tabView_schedule.Controls.Add(this.dgvClass_Shedule);
            this.tabView_schedule.Controls.Add(this.lblSubject_name_selected);
            this.tabView_schedule.Controls.Add(this.lblSubject_name);
            this.tabView_schedule.Controls.Add(this.lstSubject_list);
            this.tabView_schedule.Location = new System.Drawing.Point(4, 30);
            this.tabView_schedule.Name = "tabView_schedule";
            this.tabView_schedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabView_schedule.Size = new System.Drawing.Size(682, 249);
            this.tabView_schedule.TabIndex = 1;
            this.tabView_schedule.Text = "Class Schedule";
            this.tabView_schedule.UseVisualStyleBackColor = true;
            // 
            // dgvClass_Shedule
            // 
            this.dgvClass_Shedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass_Shedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass_Shedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Class_Start_Time,
            this.Class_End_Time});
            this.dgvClass_Shedule.Location = new System.Drawing.Point(144, 36);
            this.dgvClass_Shedule.Name = "dgvClass_Shedule";
            this.dgvClass_Shedule.RowTemplate.Height = 25;
            this.dgvClass_Shedule.Size = new System.Drawing.Size(501, 204);
            this.dgvClass_Shedule.TabIndex = 3;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            // 
            // Class_Start_Time
            // 
            this.Class_Start_Time.HeaderText = "Class Start Time";
            this.Class_Start_Time.Name = "Class_Start_Time";
            // 
            // Class_End_Time
            // 
            this.Class_End_Time.HeaderText = "Class End Time";
            this.Class_End_Time.Name = "Class_End_Time";
            // 
            // lblSubject_name_selected
            // 
            this.lblSubject_name_selected.AutoSize = true;
            this.lblSubject_name_selected.Location = new System.Drawing.Point(122, 6);
            this.lblSubject_name_selected.Name = "lblSubject_name_selected";
            this.lblSubject_name_selected.Size = new System.Drawing.Size(0, 18);
            this.lblSubject_name_selected.TabIndex = 2;
            // 
            // lblSubject_name
            // 
            this.lblSubject_name.AutoSize = true;
            this.lblSubject_name.Location = new System.Drawing.Point(8, 6);
            this.lblSubject_name.Name = "lblSubject_name";
            this.lblSubject_name.Size = new System.Drawing.Size(108, 18);
            this.lblSubject_name.TabIndex = 1;
            this.lblSubject_name.Text = "Subject Name : ";
            // 
            // lstSubject_list
            // 
            this.lstSubject_list.FormattingEnabled = true;
            this.lstSubject_list.ItemHeight = 18;
            this.lstSubject_list.Location = new System.Drawing.Point(6, 36);
            this.lstSubject_list.Name = "lstSubject_list";
            this.lstSubject_list.Size = new System.Drawing.Size(120, 148);
            this.lstSubject_list.TabIndex = 0;
            this.lstSubject_list.SelectedIndexChanged += new System.EventHandler(this.lstSubject_list_SelectedIndexChanged);
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.lblcpass);
            this.tabProfile.Controls.Add(this.txtlevel);
            this.tabProfile.Controls.Add(this.txtAddress);
            this.tabProfile.Controls.Add(this.txtemail);
            this.tabProfile.Controls.Add(this.txtcontact);
            this.tabProfile.Controls.Add(this.txtname);
            this.tabProfile.Controls.Add(this.lbllevel);
            this.tabProfile.Controls.Add(this.lbladdresserror);
            this.tabProfile.Controls.Add(this.lblemailerror);
            this.tabProfile.Controls.Add(this.lblcontacterror);
            this.tabProfile.Controls.Add(this.btnupdateprofile);
            this.tabProfile.Controls.Add(this.btneditprofile);
            this.tabProfile.Controls.Add(this.lbladdress);
            this.tabProfile.Controls.Add(this.lblemail);
            this.tabProfile.Controls.Add(this.lblcontact);
            this.tabProfile.Controls.Add(this.lblname);
            this.tabProfile.Location = new System.Drawing.Point(4, 30);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(682, 249);
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
            this.lblcpass.Location = new System.Drawing.Point(544, 229);
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
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Location = new System.Drawing.Point(378, 83);
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
            this.lbladdresserror.Location = new System.Drawing.Point(398, 66);
            this.lbladdresserror.Name = "lbladdresserror";
            this.lbladdresserror.Size = new System.Drawing.Size(0, 16);
            this.lbladdresserror.TabIndex = 31;
            // 
            // lblemailerror
            // 
            this.lblemailerror.AutoSize = true;
            this.lblemailerror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblemailerror.ForeColor = System.Drawing.Color.Red;
            this.lblemailerror.Location = new System.Drawing.Point(75, 219);
            this.lblemailerror.Name = "lblemailerror";
            this.lblemailerror.Size = new System.Drawing.Size(0, 16);
            this.lblemailerror.TabIndex = 30;
            // 
            // lblcontacterror
            // 
            this.lblcontacterror.AutoSize = true;
            this.lblcontacterror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcontacterror.ForeColor = System.Drawing.Color.Red;
            this.lblcontacterror.Location = new System.Drawing.Point(75, 143);
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
            this.lbladdress.Location = new System.Drawing.Point(378, 6);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(59, 18);
            this.lbladdress.TabIndex = 26;
            this.lbladdress.Text = "Address";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(55, 159);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(43, 18);
            this.lblemail.TabIndex = 24;
            this.lblemail.Text = "Email";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(55, 83);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(58, 18);
            this.lblcontact.TabIndex = 20;
            this.lblcontact.Text = "Contact";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(55, 6);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 18);
            this.lblname.TabIndex = 19;
            this.lblname.Text = "Name";
            // 
            // tabcon
            // 
            this.tabcon.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabcon.Controls.Add(this.tabProfile);
            this.tabcon.Controls.Add(this.tabView_schedule);
            this.tabcon.Controls.Add(this.tabRequest);
            this.tabcon.Controls.Add(this.tabPage1);
            this.tabcon.Controls.Add(this.tabUpdateStudies);
            this.tabcon.Controls.Add(this.tabPayment);
            this.tabcon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabcon.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabcon.Location = new System.Drawing.Point(0, 103);
            this.tabcon.Name = "tabcon";
            this.tabcon.SelectedIndex = 0;
            this.tabcon.Size = new System.Drawing.Size(690, 283);
            this.tabcon.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblMessage);
            this.tabPage1.Controls.Add(this.lblNew_Sub);
            this.tabPage1.Controls.Add(this.lblCurrent_sub1);
            this.tabPage1.Controls.Add(this.lblRequestid);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnWithdraw);
            this.tabPage1.Controls.Add(this.lblChange_sub_to);
            this.tabPage1.Controls.Add(this.lblCurrent_sub);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 249);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Withdraw Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMessage.Location = new System.Drawing.Point(195, 171);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 8;
            // 
            // lblNew_Sub
            // 
            this.lblNew_Sub.AutoSize = true;
            this.lblNew_Sub.Location = new System.Drawing.Point(195, 102);
            this.lblNew_Sub.Name = "lblNew_Sub";
            this.lblNew_Sub.Size = new System.Drawing.Size(0, 18);
            this.lblNew_Sub.TabIndex = 7;
            // 
            // lblCurrent_sub1
            // 
            this.lblCurrent_sub1.AutoSize = true;
            this.lblCurrent_sub1.Location = new System.Drawing.Point(195, 58);
            this.lblCurrent_sub1.Name = "lblCurrent_sub1";
            this.lblCurrent_sub1.Size = new System.Drawing.Size(0, 18);
            this.lblCurrent_sub1.TabIndex = 6;
            // 
            // lblRequestid
            // 
            this.lblRequestid.AutoSize = true;
            this.lblRequestid.Location = new System.Drawing.Point(195, 21);
            this.lblRequestid.Name = "lblRequestid";
            this.lblRequestid.Size = new System.Drawing.Size(0, 18);
            this.lblRequestid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Request ID : ";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Enabled = false;
            this.btnWithdraw.Location = new System.Drawing.Point(233, 207);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(174, 34);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw Request";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblChange_sub_to
            // 
            this.lblChange_sub_to.AutoSize = true;
            this.lblChange_sub_to.Location = new System.Drawing.Point(91, 102);
            this.lblChange_sub_to.Name = "lblChange_sub_to";
            this.lblChange_sub_to.Size = new System.Drawing.Size(84, 18);
            this.lblChange_sub_to.TabIndex = 2;
            this.lblChange_sub_to.Text = "Change to : ";
            // 
            // lblCurrent_sub
            // 
            this.lblCurrent_sub.AutoSize = true;
            this.lblCurrent_sub.Location = new System.Drawing.Point(54, 58);
            this.lblCurrent_sub.Name = "lblCurrent_sub";
            this.lblCurrent_sub.Size = new System.Drawing.Size(121, 18);
            this.lblCurrent_sub.TabIndex = 1;
            this.lblCurrent_sub.Text = "Current Subject : ";
            // 
            // tabUpdateStudies
            // 
            this.tabUpdateStudies.Controls.Add(this.lblList_of_sub_enrolled);
            this.tabUpdateStudies.Controls.Add(this.lblSub_progress);
            this.tabUpdateStudies.Controls.Add(this.lblSubject_progress);
            this.tabUpdateStudies.Controls.Add(this.lblSubject_name4);
            this.tabUpdateStudies.Controls.Add(this.btnComplete);
            this.tabUpdateStudies.Controls.Add(this.lblSubject_name3);
            this.tabUpdateStudies.Controls.Add(this.lstSubject_enrolled_list);
            this.tabUpdateStudies.Location = new System.Drawing.Point(4, 30);
            this.tabUpdateStudies.Name = "tabUpdateStudies";
            this.tabUpdateStudies.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateStudies.Size = new System.Drawing.Size(682, 249);
            this.tabUpdateStudies.TabIndex = 4;
            this.tabUpdateStudies.Text = "UpdateStudies";
            this.tabUpdateStudies.UseVisualStyleBackColor = true;
            // 
            // lblSub_progress
            // 
            this.lblSub_progress.AutoSize = true;
            this.lblSub_progress.Location = new System.Drawing.Point(355, 62);
            this.lblSub_progress.Name = "lblSub_progress";
            this.lblSub_progress.Size = new System.Drawing.Size(0, 18);
            this.lblSub_progress.TabIndex = 5;
            // 
            // lblSubject_progress
            // 
            this.lblSubject_progress.AutoSize = true;
            this.lblSubject_progress.Location = new System.Drawing.Point(212, 62);
            this.lblSubject_progress.Name = "lblSubject_progress";
            this.lblSubject_progress.Size = new System.Drawing.Size(126, 18);
            this.lblSubject_progress.TabIndex = 4;
            this.lblSubject_progress.Text = "Subject Progress : ";
            // 
            // lblSubject_name4
            // 
            this.lblSubject_name4.AutoSize = true;
            this.lblSubject_name4.Location = new System.Drawing.Point(355, 25);
            this.lblSubject_name4.Name = "lblSubject_name4";
            this.lblSubject_name4.Size = new System.Drawing.Size(0, 18);
            this.lblSubject_name4.TabIndex = 3;
            // 
            // btnComplete
            // 
            this.btnComplete.Enabled = false;
            this.btnComplete.Location = new System.Drawing.Point(252, 209);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(142, 32);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "Complete Studies";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblSubject_name3
            // 
            this.lblSubject_name3.AutoSize = true;
            this.lblSubject_name3.Location = new System.Drawing.Point(230, 25);
            this.lblSubject_name3.Name = "lblSubject_name3";
            this.lblSubject_name3.Size = new System.Drawing.Size(108, 18);
            this.lblSubject_name3.TabIndex = 1;
            this.lblSubject_name3.Text = "Subject Name : ";
            // 
            // lstSubject_enrolled_list
            // 
            this.lstSubject_enrolled_list.FormattingEnabled = true;
            this.lstSubject_enrolled_list.ItemHeight = 18;
            this.lstSubject_enrolled_list.Location = new System.Drawing.Point(20, 25);
            this.lstSubject_enrolled_list.Name = "lstSubject_enrolled_list";
            this.lstSubject_enrolled_list.Size = new System.Drawing.Size(155, 130);
            this.lstSubject_enrolled_list.TabIndex = 0;
            this.lstSubject_enrolled_list.SelectedIndexChanged += new System.EventHandler(this.lstSubject_enrolled_list_SelectedIndexChanged);
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.lblList_of_receipt);
            this.tabPayment.Controls.Add(this.lblList_of_unpaid_fee);
            this.tabPayment.Controls.Add(this.lblOutstanding);
            this.tabPayment.Controls.Add(this.btnViewReceipt);
            this.tabPayment.Controls.Add(this.btnPay);
            this.tabPayment.Controls.Add(this.lstReceipt);
            this.tabPayment.Controls.Add(this.lstUnpaidfee);
            this.tabPayment.Location = new System.Drawing.Point(4, 30);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(682, 249);
            this.tabPayment.TabIndex = 5;
            this.tabPayment.Text = "Payment";
            this.tabPayment.UseVisualStyleBackColor = true;
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.AutoSize = true;
            this.lblOutstanding.Location = new System.Drawing.Point(20, 144);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(97, 18);
            this.lblOutstanding.TabIndex = 5;
            this.lblOutstanding.Text = "Outstanding : ";
            // 
            // btnViewReceipt
            // 
            this.btnViewReceipt.Enabled = false;
            this.btnViewReceipt.Location = new System.Drawing.Point(425, 208);
            this.btnViewReceipt.Name = "btnViewReceipt";
            this.btnViewReceipt.Size = new System.Drawing.Size(108, 23);
            this.btnViewReceipt.TabIndex = 3;
            this.btnViewReceipt.Text = "View Receipt";
            this.btnViewReceipt.UseVisualStyleBackColor = true;
            this.btnViewReceipt.Click += new System.EventHandler(this.btnViewReceipt_Click);
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Location = new System.Drawing.Point(65, 208);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay ";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lstReceipt
            // 
            this.lstReceipt.FormattingEnabled = true;
            this.lstReceipt.ItemHeight = 18;
            this.lstReceipt.Location = new System.Drawing.Point(413, 30);
            this.lstReceipt.Name = "lstReceipt";
            this.lstReceipt.Size = new System.Drawing.Size(120, 94);
            this.lstReceipt.TabIndex = 1;
            this.lstReceipt.SelectedIndexChanged += new System.EventHandler(this.lstReceipt_SelectedIndexChanged);
            // 
            // lstUnpaidfee
            // 
            this.lstUnpaidfee.FormattingEnabled = true;
            this.lstUnpaidfee.ItemHeight = 18;
            this.lstUnpaidfee.Location = new System.Drawing.Point(20, 30);
            this.lstUnpaidfee.Name = "lstUnpaidfee";
            this.lstUnpaidfee.Size = new System.Drawing.Size(120, 94);
            this.lstUnpaidfee.TabIndex = 0;
            this.lstUnpaidfee.SelectedIndexChanged += new System.EventHandler(this.lstUnpaidfee_SelectedIndexChanged);
            // 
            // lblList_of_sub_enrolled
            // 
            this.lblList_of_sub_enrolled.AutoSize = true;
            this.lblList_of_sub_enrolled.Location = new System.Drawing.Point(20, 3);
            this.lblList_of_sub_enrolled.Name = "lblList_of_sub_enrolled";
            this.lblList_of_sub_enrolled.Size = new System.Drawing.Size(155, 18);
            this.lblList_of_sub_enrolled.TabIndex = 6;
            this.lblList_of_sub_enrolled.Text = "List of Subject Enrolled";
            // 
            // lblList_of_unpaid_fee
            // 
            this.lblList_of_unpaid_fee.AutoSize = true;
            this.lblList_of_unpaid_fee.Location = new System.Drawing.Point(21, 9);
            this.lblList_of_unpaid_fee.Name = "lblList_of_unpaid_fee";
            this.lblList_of_unpaid_fee.Size = new System.Drawing.Size(119, 18);
            this.lblList_of_unpaid_fee.TabIndex = 6;
            this.lblList_of_unpaid_fee.Text = "List of Unpaid fee";
            // 
            // lblList_of_receipt
            // 
            this.lblList_of_receipt.AutoSize = true;
            this.lblList_of_receipt.Location = new System.Drawing.Point(413, 9);
            this.lblList_of_receipt.Name = "lblList_of_receipt";
            this.lblList_of_receipt.Size = new System.Drawing.Size(98, 18);
            this.lblList_of_receipt.TabIndex = 7;
            this.lblList_of_receipt.Text = "List of Receipt";
            // 
            // StudentHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(690, 386);
            this.Controls.Add(this.tabcon);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.lbltuitioname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentHomePage";
            this.Text = "StudentHomePage";
            this.Load += new System.EventHandler(this.StudentHomePage_Load);
            this.tabRequest.ResumeLayout(false);
            this.tabRequest.PerformLayout();
            this.tabView_schedule.ResumeLayout(false);
            this.tabView_schedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass_Shedule)).EndInit();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.tabcon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabUpdateStudies.ResumeLayout(false);
            this.tabUpdateStudies.PerformLayout();
            this.tabPayment.ResumeLayout(false);
            this.tabPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbltuitioname;
        private Label lblwelcome;
        private TabPage tabRequest;
        private Label lblsublist2;
        private Label lblsublist;
        private Button btnRequest;
        private ListBox lstchange_Sub_list;
        private ListBox lstcurrent_erolled_sub;
        private TabPage tabView_schedule;
        private DataGridView dgvClass_Shedule;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Class_Start_Time;
        private DataGridViewTextBoxColumn Class_End_Time;
        private Label lblSubject_name_selected;
        private Label lblSubject_name;
        private ListBox lstSubject_list;
        private TabPage tabProfile;
        private Label lblcpass;
        private TextBox txtlevel;
        private TextBox txtAddress;
        private TextBox txtemail;
        private TextBox txtcontact;
        private TextBox txtname;
        private Label lbllevel;
        private Label lbladdresserror;
        private Label lblemailerror;
        private Label lblcontacterror;
        private Button btnupdateprofile;
        private Button btneditprofile;
        private Label lbladdress;
        private Label lblemail;
        private Label lblcontact;
        private Label lblname;
        private TabControl tabcon;
        private Label lblSub_name;
        private Label lblSub_name1;
        private Label lblChange_sub_name;
        private Label lblcurrent_sub_name;
        private TabPage tabPage1;
        private Button btnWithdraw;
        private Label lblChange_sub_to;
        private Label lblCurrent_sub;
        private Label lblNew_Sub;
        private Label lblCurrent_sub1;
        private Label lblRequestid;
        private Label label1;
        private Label lblMessage;
        private TabPage tabUpdateStudies;
        private Label lblSub_progress;
        private Label lblSubject_progress;
        private Label lblSubject_name4;
        private Button btnComplete;
        private Label lblSubject_name3;
        private ListBox lstSubject_enrolled_list;
        private TabPage tabPayment;
        private Label lblOutstanding;
        private Button btnViewReceipt;
        private Button btnPay;
        private ListBox lstReceipt;
        private ListBox lstUnpaidfee;
        private Label lblList_of_sub_enrolled;
        private Label lblList_of_receipt;
        private Label lblList_of_unpaid_fee;
    }
}