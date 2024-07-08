namespace EmployeeReg
{
    partial class Delete
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
            this.CloseUpdate = new System.Windows.Forms.Button();
            this.Go = new System.Windows.Forms.Button();
            this.Records = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PicturEmp = new System.Windows.Forms.PictureBox();
            this.DeptID = new System.Windows.Forms.ComboBox();
            this.DeleteRec = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.Salary = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FindEmp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicturEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseUpdate
            // 
            this.CloseUpdate.BackColor = System.Drawing.Color.Red;
            this.CloseUpdate.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseUpdate.Location = new System.Drawing.Point(886, 636);
            this.CloseUpdate.Name = "CloseUpdate";
            this.CloseUpdate.Size = new System.Drawing.Size(132, 58);
            this.CloseUpdate.TabIndex = 72;
            this.CloseUpdate.Text = "Close";
            this.CloseUpdate.UseVisualStyleBackColor = false;
            // 
            // Go
            // 
            this.Go.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.Location = new System.Drawing.Point(591, 149);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(91, 43);
            this.Go.TabIndex = 71;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.button3_Click);
            // 
            // Records
            // 
            this.Records.AutoSize = true;
            this.Records.Location = new System.Drawing.Point(912, 413);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(0, 16);
            this.Records.TabIndex = 68;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Info;
            this.Clear.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(1053, 636);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(175, 58);
            this.Clear.TabIndex = 67;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1460, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 48);
            this.button2.TabIndex = 66;
            this.button2.Text = "Image";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // PicturEmp
            // 
            this.PicturEmp.BackColor = System.Drawing.Color.AliceBlue;
            this.PicturEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicturEmp.Location = new System.Drawing.Point(1392, 154);
            this.PicturEmp.Name = "PicturEmp";
            this.PicturEmp.Size = new System.Drawing.Size(212, 178);
            this.PicturEmp.TabIndex = 65;
            this.PicturEmp.TabStop = false;
            // 
            // DeptID
            // 
            this.DeptID.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptID.FormattingEnabled = true;
            this.DeptID.Location = new System.Drawing.Point(301, 698);
            this.DeptID.Name = "DeptID";
            this.DeptID.Size = new System.Drawing.Size(258, 31);
            this.DeptID.TabIndex = 64;
            // 
            // DeleteRec
            // 
            this.DeleteRec.BackColor = System.Drawing.Color.Lime;
            this.DeleteRec.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRec.Location = new System.Drawing.Point(1305, 636);
            this.DeleteRec.Name = "DeleteRec";
            this.DeleteRec.Size = new System.Drawing.Size(175, 58);
            this.DeleteRec.TabIndex = 63;
            this.DeleteRec.Text = "Delete Record";
            this.DeleteRec.UseVisualStyleBackColor = false;
            this.DeleteRec.Click += new System.EventHandler(this.DeleteRec_Click);
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.Gender.Location = new System.Drawing.Point(301, 418);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(152, 45);
            this.Gender.TabIndex = 62;
            // 
            // BirthDate
            // 
            this.BirthDate.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Location = new System.Drawing.Point(301, 368);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(463, 35);
            this.BirthDate.TabIndex = 61;
            // 
            // Salary
            // 
            this.Salary.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(301, 601);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(122, 44);
            this.Salary.TabIndex = 60;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(301, 517);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(344, 44);
            this.Address.TabIndex = 59;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(967, 276);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(183, 44);
            this.LastName.TabIndex = 58;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(301, 270);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(197, 44);
            this.FirstName.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 690);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 38);
            this.label10.TabIndex = 56;
            this.label10.Text = "Dept ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 592);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 38);
            this.label9.TabIndex = 55;
            this.label9.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 38);
            this.label8.TabIndex = 54;
            this.label8.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 38);
            this.label6.TabIndex = 53;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 38);
            this.label5.TabIndex = 52;
            this.label5.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(740, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 38);
            this.label4.TabIndex = 51;
            this.label4.Text = "Last_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 38);
            this.label3.TabIndex = 50;
            this.label3.Text = "First_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 64);
            this.label1.TabIndex = 49;
            this.label1.Text = "Employee Record Delete";
            // 
            // FindEmp
            // 
            this.FindEmp.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindEmp.FormattingEnabled = true;
            this.FindEmp.Location = new System.Drawing.Point(67, 154);
            this.FindEmp.Name = "FindEmp";
            this.FindEmp.Size = new System.Drawing.Size(492, 35);
            this.FindEmp.TabIndex = 73;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1765, 755);
            this.Controls.Add(this.FindEmp);
            this.Controls.Add(this.CloseUpdate);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PicturEmp);
            this.Controls.Add(this.DeptID);
            this.Controls.Add(this.DeleteRec);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicturEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseUpdate;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label Records;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox PicturEmp;
        private System.Windows.Forms.ComboBox DeptID;
        private System.Windows.Forms.Button DeleteRec;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FindEmp;
    }
}