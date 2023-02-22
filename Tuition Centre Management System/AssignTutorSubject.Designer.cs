namespace Tuition_Centre_Management_System
{
    partial class AssignTutorSubject
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
            this.lstTutorID = new System.Windows.Forms.ListBox();
            this.lstSubjectID = new System.Windows.Forms.ListBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTutorName = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblTutName = new System.Windows.Forms.Label();
            this.lblsubName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTutorID
            // 
            this.lstTutorID.FormattingEnabled = true;
            this.lstTutorID.ItemHeight = 15;
            this.lstTutorID.Location = new System.Drawing.Point(39, 59);
            this.lstTutorID.Name = "lstTutorID";
            this.lstTutorID.Size = new System.Drawing.Size(120, 94);
            this.lstTutorID.TabIndex = 0;
            this.lstTutorID.SelectedIndexChanged += new System.EventHandler(this.lstTutorID_SelectedIndexChanged);
            // 
            // lstSubjectID
            // 
            this.lstSubjectID.FormattingEnabled = true;
            this.lstSubjectID.ItemHeight = 15;
            this.lstSubjectID.Location = new System.Drawing.Point(39, 202);
            this.lstSubjectID.Name = "lstSubjectID";
            this.lstSubjectID.Size = new System.Drawing.Size(120, 94);
            this.lstSubjectID.TabIndex = 1;
            this.lstSubjectID.SelectedIndexChanged += new System.EventHandler(this.lstSubjectID_SelectedIndexChanged);
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Form 1",
            "Form 2",
            "Form 3",
            "Form 4",
            "Form 5"});
            this.cmbLevel.Location = new System.Drawing.Point(180, 59);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(121, 23);
            this.cmbLevel.TabIndex = 2;
            this.cmbLevel.SelectedIndexChanged += new System.EventHandler(this.cmbLevel_SelectedIndexChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.Enabled = false;
            this.btnAssign.Location = new System.Drawing.Point(248, 273);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Tutor From Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tutor ID list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject List";
            // 
            // lblTutorName
            // 
            this.lblTutorName.AutoSize = true;
            this.lblTutorName.Location = new System.Drawing.Point(191, 103);
            this.lblTutorName.Name = "lblTutorName";
            this.lblTutorName.Size = new System.Drawing.Size(79, 15);
            this.lblTutorName.TabIndex = 7;
            this.lblTutorName.Text = "Tutor Name : ";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(180, 138);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(90, 15);
            this.lblSubjectName.TabIndex = 8;
            this.lblSubjectName.Text = "Subject Name : ";
            // 
            // lblTutName
            // 
            this.lblTutName.AutoSize = true;
            this.lblTutName.Location = new System.Drawing.Point(266, 103);
            this.lblTutName.Name = "lblTutName";
            this.lblTutName.Size = new System.Drawing.Size(0, 15);
            this.lblTutName.TabIndex = 9;
            // 
            // lblsubName
            // 
            this.lblsubName.AutoSize = true;
            this.lblsubName.Location = new System.Drawing.Point(266, 138);
            this.lblsubName.Name = "lblsubName";
            this.lblsubName.Size = new System.Drawing.Size(0, 15);
            this.lblsubName.TabIndex = 10;
            // 
            // AssignTutorSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 331);
            this.Controls.Add(this.lblsubName);
            this.Controls.Add(this.lblTutName);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.lblTutorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.lstSubjectID);
            this.Controls.Add(this.lstTutorID);
            this.Name = "AssignTutorSubject";
            this.Text = "AssignTutorSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstTutorID;
        private ListBox lstSubjectID;
        private ComboBox cmbLevel;
        private Button btnAssign;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTutorName;
        private Label lblSubjectName;
        private Label lblTutName;
        private Label lblsubName;
    }
}