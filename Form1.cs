using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeReg
{

    public partial class Form1 : Form
    {
       private double age;


        private  int newEmpId = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void WriteDeptID()
        {
            using (BinaryWriter IObjBW = new BinaryWriter(File.Open("C:\\Users\\singh\\Desktop\\Employee\\" +
              "DeptID.dat", FileMode.Create)))
            {

                IObjBW.Write("341:Java Developer");
                IObjBW.Write("437:Sales");
                IObjBW.Write("546:Marketing");
                IObjBW.Write("123:Plumber");




            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveToFile(FirstName.Text, LastName.Text, BirthDate.Text, Gender.Text, Address.Text, Salary.Text, DeptID.Text, openFileDialog1.FileName);
            MessageBox.Show("Saved");
            Records.Text += "Employee ID :- " + newEmpId + "\n";
            Records.Text += "Name:- " + FirstName.Text + LastName.Text+"\n";
            Records.Text += "BirthDate:- " + BirthDate.Text + "\n";
            Records.Text += "Gender:- " + Gender.Text + "\n";
            Records.Text += "Age:-" + age + "\n";
            Records.Text += "Address :- " + Address.Text + "\n";
            Records.Text += "Salary :- " + Salary.Text + "\n";
            Records.Text += "Dept ID:-" + DeptID.Text;
        }
        private double AgeCalculate(DateTime birthDate)
        {
            TimeSpan lobjTimeSpan = DateTime.Now.Subtract((DateTime)birthDate);


            age = lobjTimeSpan.TotalDays / 365.0;
            return age;
        }
        private void SaveToFile(string FirstName, string LastName, string BirthDate, string gender, string Address, string salary, string deptid, string FilePath)
        {
            double lnAge = AgeCalculate(DateTime.Parse(BirthDate));
            string filePath = @"C:\Users\singh\Desktop\Employee\EmployeeRec.dat";

           
            
            if (File.Exists(filePath))
            {
                string[] existingRecords = File.ReadAllLines(filePath);
                if (existingRecords.Length > 0)
                {
                    string lastRecord = existingRecords.Last();
                    string lastEmpIdString = lastRecord.Split('|')[1];
                    if (int.TryParse(lastEmpIdString, out int lastEmpId))
                    {
                        newEmpId = lastEmpId + 1;
                    }
                }
            }

            using (BinaryWriter IObjBW = new BinaryWriter(File.Open(filePath, FileMode.Append)))
            {
                string record = $"|{newEmpId}|{FirstName}|{LastName}|{BirthDate}|{gender}|{lnAge}|{Address}|{salary}|{deptid}|{FilePath}";
                IObjBW.Write(record + "\n");
            }

            
        }
        private void LoadDeptID()
        {
            using (FileStream fs = new FileStream("C:\\Users\\singh\\Desktop\\Employee\\" +
              "DeptID.dat",
        FileMode.Open, FileAccess.Read))
            using (BinaryReader IObjReader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    string lsDeptID = IObjReader.ReadString();
                    DeptID.Items.Add(lsDeptID);
                }

            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WriteDeptID();
            LoadDeptID();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files | *.bmp;*.jpg;*.jpeg|PNG File|*.png;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox1.Load(openFileDialog1.FileName);
                pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            BirthDate.Text = "";
            Gender.Text = "";
            Address.Text = "";
            Salary.Text = "";
            DeptID.Text = "";
            Records.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update lobjUpdate = new Update();
            lobjUpdate.ShowDialog();
        }
    }
    
}
