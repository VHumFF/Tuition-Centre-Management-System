namespace Tuition_Centre_Management_System
{
    partial class ReceptionistHomePage
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
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lbltuitioname = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabconprofile = new System.Windows.Forms.TabControl();
            this.tabprofile.SuspendLayout();
            this.tabconprofile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(24, 45);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(126, 30);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "lblwelcome";
            // 
            // lbltuitioname
            // 
            this.lbltuitioname.AutoSize = true;
            this.lbltuitioname.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltuitioname.ForeColor = System.Drawing.Color.White;
            this.lbltuitioname.Location = new System.Drawing.Point(362, 0);
            this.lbltuitioname.Name = "lbltuitioname";
            this.lbltuitioname.Size = new System.Drawing.Size(295, 23);
            this.lbltuitioname.TabIndex = 2;
            this.lbltuitioname.Text = "Excellent Tuition Centre";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(651, 249);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(651, 249);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabprofile.Size = new System.Drawing.Size(651, 249);
            this.tabprofile.TabIndex = 0;
            this.tabprofile.Text = "Profile";
            this.tabprofile.UseVisualStyleBackColor = true;
            this.tabprofile.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lbladdresserror
            // 
            this.lbladdresserror.AutoSize = true;
            this.lbladdresserror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbladdresserror.ForeColor = System.Drawing.Color.Red;
            this.lbladdresserror.Location = new System.Drawing.Point(375, 74);
            this.lbladdresserror.Name = "lbladdresserror";
            this.lbladdresserror.Size = new System.Drawing.Size(0, 16);
            this.lbladdresserror.TabIndex = 18;
            // 
            // lblemailerror
            // 
            this.lblemailerror.AutoSize = true;
            this.lblemailerror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblemailerror.ForeColor = System.Drawing.Color.Red;
            this.lblemailerror.Location = new System.Drawing.Point(52, 228);
            this.lblemailerror.Name = "lblemailerror";
            this.lblemailerror.Size = new System.Drawing.Size(0, 16);
            this.lblemailerror.TabIndex = 17;
            // 
            // lblcontacterror
            // 
            this.lblcontacterror.AutoSize = true;
            this.lblcontacterror.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcontacterror.ForeColor = System.Drawing.Color.Red;
            this.lblcontacterror.Location = new System.Drawing.Point(52, 151);
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
            this.lblcpass.Location = new System.Drawing.Point(541, 226);
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
            this.btnupdateprofile.Click += new System.EventHandler(this.btnupdateprofile_Click);
            // 
            // btneditprofile
            // 
            this.btneditprofile.Location = new System.Drawing.Point(375, 118);
            this.btneditprofile.Name = "btneditprofile";
            this.btneditprofile.Size = new System.Drawing.Size(117, 30);
            this.btneditprofile.TabIndex = 13;
            this.btneditprofile.Text = "Edit Profile";
            this.btneditprofile.UseVisualStyleBackColor = true;
            this.btneditprofile.Click += new System.EventHandler(this.btneditprofile_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(375, 27);
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
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
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
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
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
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
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
            this.lblemail.Location = new System.Drawing.Point(52, 180);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(43, 18);
            this.lblemail.TabIndex = 9;
            this.lblemail.Text = "Email";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(52, 104);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(58, 18);
            this.lblcontact.TabIndex = 3;
            this.lblcontact.Text = "Contact";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(52, 27);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 18);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name";
            this.lblname.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabconprofile
            // 
            this.tabconprofile.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabconprofile.Controls.Add(this.tabprofile);
            this.tabconprofile.Controls.Add(this.tabPage2);
            this.tabconprofile.Controls.Add(this.tabPage3);
            this.tabconprofile.Controls.Add(this.tabPage4);
            this.tabconprofile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabconprofile.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabconprofile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabconprofile.Location = new System.Drawing.Point(0, 103);
            this.tabconprofile.Multiline = true;
            this.tabconprofile.Name = "tabconprofile";
            this.tabconprofile.SelectedIndex = 0;
            this.tabconprofile.Size = new System.Drawing.Size(659, 283);
            this.tabconprofile.TabIndex = 0;
            // 
            // ReceptionistHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(659, 386);
            this.Controls.Add(this.lbltuitioname);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.tabconprofile);
            this.Name = "ReceptionistHomePage";
            this.Text = "ReceptionistPage";
            this.Load += new System.EventHandler(this.ReceptionistHomePage_Load);
            this.tabprofile.ResumeLayout(false);
            this.tabprofile.PerformLayout();
            this.tabconprofile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblwelcome;
        private Label lbltuitioname;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage2;
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
        private TabControl tabconprofile;
    }
}