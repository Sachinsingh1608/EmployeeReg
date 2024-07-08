namespace EmployeeReg
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeptID = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Clear = new System.Windows.Forms.Button();
            this.Records = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.CloseReg = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.DeleteRec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "First_Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(731, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last_Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "BirthDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 38);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 38);
            this.label9.TabIndex = 8;
            this.label9.Text = "Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 38);
            this.label10.TabIndex = 9;
            this.label10.Text = "Dept ID";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(292, 104);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(197, 44);
            this.FirstName.TabIndex = 10;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(958, 110);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(183, 44);
            this.LastName.TabIndex = 11;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(292, 351);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(344, 44);
            this.Address.TabIndex = 13;
            // 
            // Salary
            // 
            this.Salary.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(292, 435);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(122, 44);
            this.Salary.TabIndex = 14;
            // 
            // BirthDate
            // 
            this.BirthDate.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Location = new System.Drawing.Point(292, 202);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(463, 35);
            this.BirthDate.TabIndex = 17;
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Open Sans Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.Gender.Location = new System.Drawing.Point(292, 252);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(152, 45);
            this.Gender.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1290, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 58);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeptID
            // 
            this.DeptID.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptID.FormattingEnabled = true;
            this.DeptID.Location = new System.Drawing.Point(292, 532);
            this.DeptID.Name = "DeptID";
            this.DeptID.Size = new System.Drawing.Size(258, 31);
            this.DeptID.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1359, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 178);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1445, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 48);
            this.button2.TabIndex = 22;
            this.button2.Text = "Image";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Info;
            this.Clear.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(1098, 592);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(175, 58);
            this.Clear.TabIndex = 23;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Records
            // 
            this.Records.AutoSize = true;
            this.Records.Location = new System.Drawing.Point(903, 247);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(0, 16);
            this.Records.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1383, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 52);
            this.button3.TabIndex = 25;
            this.button3.Text = "Update Record";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CloseReg
            // 
            this.CloseReg.BackColor = System.Drawing.Color.Red;
            this.CloseReg.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseReg.Location = new System.Drawing.Point(879, 592);
            this.CloseReg.Name = "CloseReg";
            this.CloseReg.Size = new System.Drawing.Size(160, 58);
            this.CloseReg.TabIndex = 26;
            this.CloseReg.Text = "Close";
            this.CloseReg.UseVisualStyleBackColor = false;
            this.CloseReg.Click += new System.EventHandler(this.CloseReg_Click);
            // 
            // DeleteRec
            // 
            this.DeleteRec.BackColor = System.Drawing.Color.Lime;
            this.DeleteRec.Font = new System.Drawing.Font("Open Sans Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRec.Location = new System.Drawing.Point(1163, 12);
            this.DeleteRec.Name = "DeleteRec";
            this.DeleteRec.Size = new System.Drawing.Size(188, 52);
            this.DeleteRec.TabIndex = 27;
            this.DeleteRec.Text = "Delete Record";
            this.DeleteRec.UseVisualStyleBackColor = false;
            this.DeleteRec.Click += new System.EventHandler(this.DeleteRec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1713, 684);
            this.Controls.Add(this.DeleteRec);
            this.Controls.Add(this.CloseReg);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox DeptID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label Records;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CloseReg;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button DeleteRec;
    }
}

