namespace Tuition_Centre_Management_System
{
    partial class changePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePassword));
            this.picuser = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblcurrentpass = new System.Windows.Forms.Label();
            this.txtcurrentpass = new System.Windows.Forms.TextBox();
            this.lblnewpass = new System.Windows.Forms.Label();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.lblcomfirmpass = new System.Windows.Forms.Label();
            this.txtcomfirmpass = new System.Windows.Forms.TextBox();
            this.lblcurrentpasserror = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnchangepass = new System.Windows.Forms.Button();
            this.lblnewpasserror = new System.Windows.Forms.Label();
            this.lblcomfirmpasserror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            this.SuspendLayout();
            // 
            // picuser
            // 
            this.picuser.Image = ((System.Drawing.Image)(resources.GetObject("picuser.Image")));
            this.picuser.Location = new System.Drawing.Point(2, 12);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(60, 57);
            this.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picuser.TabIndex = 5;
            this.picuser.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Gill Sans MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(68, 12);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(168, 27);
            this.lbltitle.TabIndex = 6;
            this.lbltitle.Text = "Changing password for";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(68, 39);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(115, 30);
            this.lblusername.TabIndex = 7;
            this.lblusername.Text = "Username";
            // 
            // lblcurrentpass
            // 
            this.lblcurrentpass.AutoSize = true;
            this.lblcurrentpass.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcurrentpass.ForeColor = System.Drawing.Color.White;
            this.lblcurrentpass.Location = new System.Drawing.Point(2, 102);
            this.lblcurrentpass.Name = "lblcurrentpass";
            this.lblcurrentpass.Size = new System.Drawing.Size(128, 23);
            this.lblcurrentpass.TabIndex = 8;
            this.lblcurrentpass.Text = "Current password";
            // 
            // txtcurrentpass
            // 
            this.txtcurrentpass.Location = new System.Drawing.Point(139, 102);
            this.txtcurrentpass.Name = "txtcurrentpass";
            this.txtcurrentpass.PasswordChar = '*';
            this.txtcurrentpass.Size = new System.Drawing.Size(154, 23);
            this.txtcurrentpass.TabIndex = 9;
            this.txtcurrentpass.TextChanged += new System.EventHandler(this.txtcurrentpass_TextChanged);
            // 
            // lblnewpass
            // 
            this.lblnewpass.AutoSize = true;
            this.lblnewpass.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnewpass.ForeColor = System.Drawing.Color.White;
            this.lblnewpass.Location = new System.Drawing.Point(2, 161);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(109, 23);
            this.lblnewpass.TabIndex = 10;
            this.lblnewpass.Text = "New password";
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(139, 161);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '*';
            this.txtnewpass.Size = new System.Drawing.Size(154, 23);
            this.txtnewpass.TabIndex = 11;
            this.txtnewpass.TextChanged += new System.EventHandler(this.txtnewpass_TextChanged);
            // 
            // lblcomfirmpass
            // 
            this.lblcomfirmpass.AutoSize = true;
            this.lblcomfirmpass.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcomfirmpass.ForeColor = System.Drawing.Color.White;
            this.lblcomfirmpass.Location = new System.Drawing.Point(2, 201);
            this.lblcomfirmpass.Name = "lblcomfirmpass";
            this.lblcomfirmpass.Size = new System.Drawing.Size(134, 23);
            this.lblcomfirmpass.TabIndex = 12;
            this.lblcomfirmpass.Text = "Comfirm password";
            // 
            // txtcomfirmpass
            // 
            this.txtcomfirmpass.Location = new System.Drawing.Point(139, 201);
            this.txtcomfirmpass.Name = "txtcomfirmpass";
            this.txtcomfirmpass.PasswordChar = '*';
            this.txtcomfirmpass.Size = new System.Drawing.Size(154, 23);
            this.txtcomfirmpass.TabIndex = 13;
            this.txtcomfirmpass.Click += new System.EventHandler(this.txtcomfirmpass_Click);
            this.txtcomfirmpass.TextChanged += new System.EventHandler(this.txtcomfirmpass_TextChanged);
            // 
            // lblcurrentpasserror
            // 
            this.lblcurrentpasserror.AutoSize = true;
            this.lblcurrentpasserror.Location = new System.Drawing.Point(140, 128);
            this.lblcurrentpasserror.Name = "lblcurrentpasserror";
            this.lblcurrentpasserror.Size = new System.Drawing.Size(38, 15);
            this.lblcurrentpasserror.TabIndex = 14;
            this.lblcurrentpasserror.Text = "label4";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(90, 277);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnchangepass
            // 
            this.btnchangepass.Enabled = false;
            this.btnchangepass.Location = new System.Drawing.Point(182, 277);
            this.btnchangepass.Name = "btnchangepass";
            this.btnchangepass.Size = new System.Drawing.Size(111, 23);
            this.btnchangepass.TabIndex = 16;
            this.btnchangepass.Text = "Change Password";
            this.btnchangepass.UseVisualStyleBackColor = true;
            this.btnchangepass.Click += new System.EventHandler(this.btnchangepass_Click);
            // 
            // lblnewpasserror
            // 
            this.lblnewpasserror.AutoSize = true;
            this.lblnewpasserror.Location = new System.Drawing.Point(140, 183);
            this.lblnewpasserror.Name = "lblnewpasserror";
            this.lblnewpasserror.Size = new System.Drawing.Size(38, 15);
            this.lblnewpasserror.TabIndex = 17;
            this.lblnewpasserror.Text = "label5";
            // 
            // lblcomfirmpasserror
            // 
            this.lblcomfirmpasserror.AutoSize = true;
            this.lblcomfirmpasserror.Location = new System.Drawing.Point(139, 227);
            this.lblcomfirmpasserror.Name = "lblcomfirmpasserror";
            this.lblcomfirmpasserror.Size = new System.Drawing.Size(38, 15);
            this.lblcomfirmpasserror.TabIndex = 18;
            this.lblcomfirmpasserror.Text = "label6";
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(305, 312);
            this.Controls.Add(this.lblcomfirmpasserror);
            this.Controls.Add(this.lblnewpasserror);
            this.Controls.Add(this.btnchangepass);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblcurrentpasserror);
            this.Controls.Add(this.txtcomfirmpass);
            this.Controls.Add(this.lblcomfirmpass);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.lblnewpass);
            this.Controls.Add(this.txtcurrentpass);
            this.Controls.Add(this.lblcurrentpass);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.picuser);
            this.Name = "changePassword";
            this.Text = "changePassword";
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picuser;
        private Label lbltitle;
        private Label lblusername;
        private Label lblcurrentpass;
        private TextBox txtcurrentpass;
        private Label lblnewpass;
        private TextBox txtnewpass;
        private Label lblcomfirmpass;
        private TextBox txtcomfirmpass;
        private Label lblcurrentpasserror;
        private Button btnclose;
        private Button btnchangepass;
        private Label lblnewpasserror;
        private Label lblcomfirmpasserror;
    }
}