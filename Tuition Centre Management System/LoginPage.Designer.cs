namespace Tuition_Centre_Management_System
{
    partial class frmLoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginPage));
            this.lblTuitionCentre = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTuitionCentre2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picboxUsername = new System.Windows.Forms.PictureBox();
            this.picboxPassword = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picboxShowPass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTuitionCentre
            // 
            this.lblTuitionCentre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTuitionCentre.Font = new System.Drawing.Font("Showcard Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTuitionCentre.ForeColor = System.Drawing.Color.White;
            this.lblTuitionCentre.Location = new System.Drawing.Point(0, 0);
            this.lblTuitionCentre.Name = "lblTuitionCentre";
            this.lblTuitionCentre.Size = new System.Drawing.Size(324, 68);
            this.lblTuitionCentre.TabIndex = 0;
            this.lblTuitionCentre.Text = "Excellent";
            this.lblTuitionCentre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTuitionCentre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(88, 139);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(167, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // lblTuitionCentre2
            // 
            this.lblTuitionCentre2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTuitionCentre2.Font = new System.Drawing.Font("Showcard Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTuitionCentre2.ForeColor = System.Drawing.Color.White;
            this.lblTuitionCentre2.Location = new System.Drawing.Point(0, 68);
            this.lblTuitionCentre2.Name = "lblTuitionCentre2";
            this.lblTuitionCentre2.Size = new System.Drawing.Size(324, 55);
            this.lblTuitionCentre2.TabIndex = 3;
            this.lblTuitionCentre2.Text = "Tuition Centre";
            this.lblTuitionCentre2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(88, 190);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(167, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // picboxUsername
            // 
            this.picboxUsername.Image = global::Tuition_Centre_Management_System.Properties.Resources.user;
            this.picboxUsername.Location = new System.Drawing.Point(57, 139);
            this.picboxUsername.Name = "picboxUsername";
            this.picboxUsername.Size = new System.Drawing.Size(25, 23);
            this.picboxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxUsername.TabIndex = 4;
            this.picboxUsername.TabStop = false;
            // 
            // picboxPassword
            // 
            this.picboxPassword.Image = ((System.Drawing.Image)(resources.GetObject("picboxPassword.Image")));
            this.picboxPassword.Location = new System.Drawing.Point(57, 190);
            this.picboxPassword.Name = "picboxPassword";
            this.picboxPassword.Size = new System.Drawing.Size(25, 23);
            this.picboxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPassword.TabIndex = 5;
            this.picboxPassword.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(121, 238);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 32);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picboxShowPass
            // 
            this.picboxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxShowPass.Image = ((System.Drawing.Image)(resources.GetObject("picboxShowPass.Image")));
            this.picboxShowPass.Location = new System.Drawing.Point(261, 190);
            this.picboxShowPass.Name = "picboxShowPass";
            this.picboxShowPass.Size = new System.Drawing.Size(25, 23);
            this.picboxShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxShowPass.TabIndex = 6;
            this.picboxShowPass.TabStop = false;
            this.picboxShowPass.Click += new System.EventHandler(this.picboxShowPass_Click);
            // 
            // frmLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(324, 298);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picboxShowPass);
            this.Controls.Add(this.picboxPassword);
            this.Controls.Add(this.picboxUsername);
            this.Controls.Add(this.lblTuitionCentre2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblTuitionCentre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLoginPage";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxShowPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTuitionCentre;
        private TextBox txtUsername;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblTuitionCentre2;
        private TextBox txtPassword;
        private PictureBox picboxUsername;
        private PictureBox picboxPassword;
        private Button btnLogin;
        public PictureBox picboxShowPass;
    }
}