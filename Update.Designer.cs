namespace EmployeeReg
{
    partial class Update
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
            this.Records = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PicturEmp = new System.Windows.Forms.PictureBox();
            this.DeptID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.FindEmp = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CloseUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicturEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // Records
            // 
            this.Records.AutoSize = true;
            this.Records.Location = new System.Drawing.Point(890, 406);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(0, 16);
            this.Records.TabIndex = 44;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Info;
            this.Clear.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(1031, 629);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(175, 58);
            this.Clear.TabIndex = 43;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1438, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 48);
            this.button2.TabIndex = 42;
            this.button2.Text = "Image";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PicturEmp
            // 
            this.PicturEmp.BackColor = System.Drawing.Color.AliceBlue;
            this.PicturEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicturEmp.Location = new System.Drawing.Point(1352, 147);
            this.PicturEmp.Name = "PicturEmp";
            this.PicturEmp.Size = new System.Drawing.Size(212, 178);
            this.PicturEmp.TabIndex = 41;
            this.PicturEmp.TabStop = false;
            // 
            // DeptID
            // 
            this.DeptID.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptID.FormattingEnabled = true;
            this.DeptID.Location = new System.Drawing.Point(279, 691);
            this.DeptID.Name = "DeptID";
            this.DeptID.Size = new System.Drawing.Size(258, 31);
            this.DeptID.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1283, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 58);
            this.button1.TabIndex = 39;
            this.button1.Text = "Update Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.Gender.Location = new System.Drawing.Point(279, 411);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(152, 45);
            this.Gender.TabIndex = 38;
            // 
            // BirthDate
            // 
            this.BirthDate.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Location = new System.Drawing.Point(279, 361);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(463, 35);
            this.BirthDate.TabIndex = 37;
            // 
            // Salary
            // 
            this.Salary.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(279, 594);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(122, 44);
            this.Salary.TabIndex = 36;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(279, 510);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(344, 44);
            this.Address.TabIndex = 35;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(945, 269);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(183, 44);
            this.LastName.TabIndex = 34;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(279, 263);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(197, 44);
            this.FirstName.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 683);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 38);
            this.label10.TabIndex = 32;
            this.label10.Text = "Dept ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 38);
            this.label9.TabIndex = 31;
            this.label9.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 38);
            this.label8.TabIndex = 30;
            this.label8.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 38);
            this.label6.TabIndex = 29;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 38);
            this.label5.TabIndex = 28;
            this.label5.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(718, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 38);
            this.label4.TabIndex = 27;
            this.label4.Text = "Last_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 38);
            this.label3.TabIndex = 26;
            this.label3.Text = "First_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 64);
            this.label1.TabIndex = 25;
            this.label1.Text = "Employee Updation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 38);
            this.label2.TabIndex = 45;
            this.label2.Text = "EmpID";
            // 
            // FindEmp
            // 
            this.FindEmp.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindEmp.Location = new System.Drawing.Point(279, 147);
            this.FindEmp.Name = "FindEmp";
            this.FindEmp.Size = new System.Drawing.Size(197, 44);
            this.FindEmp.TabIndex = 46;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(482, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 50);
            this.button3.TabIndex = 47;
            this.button3.Text = "Go";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CloseUpdate
            // 
            this.CloseUpdate.BackColor = System.Drawing.Color.Red;
            this.CloseUpdate.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseUpdate.Location = new System.Drawing.Point(864, 629);
            this.CloseUpdate.Name = "CloseUpdate";
            this.CloseUpdate.Size = new System.Drawing.Size(132, 58);
            this.CloseUpdate.TabIndex = 48;
            this.CloseUpdate.Text = "Close";
            this.CloseUpdate.UseVisualStyleBackColor = false;
            this.CloseUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1584, 733);
            this.Controls.Add(this.CloseUpdate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FindEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PicturEmp);
            this.Controls.Add(this.DeptID);
            this.Controls.Add(this.button1);
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
            this.Name = "Update";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.PicturEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Records;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox PicturEmp;
        private System.Windows.Forms.ComboBox DeptID;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FindEmp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CloseUpdate;
    }
}