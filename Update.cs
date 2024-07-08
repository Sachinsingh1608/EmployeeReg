using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeReg
{
    public partial class Update : Form
    {
        private List<string> EmpID = new List<string>();
        private List<string> _firstName = new List<string>();
        private List<string> _lastName = new List<string>();
        private List<string> _BirthDate = new List<string>();
        private List<string> _Gender = new List<string>();
        private List<double> _Age = new List<double>();
        private List<string> _Addresss = new List<string>();
        private List<string> _Salary = new List<string>();
        private List<string> _DeptIDs = new List<string>();
        private List<string> _PictureFilePath = new List<string>();
        public Update()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string lsEmpIdAndName = (FindEmp.Text);
            string lsEmpId = lsEmpIdAndName.Split('|')[0];
            bool lbEmpID = (EmpID.Contains(lsEmpId));
            if (lbEmpID == true)
            {
                int EmpIDAt = EmpID.IndexOf(lsEmpId);
                FirstName.Text = _firstName[EmpIDAt];
                LastName.Text = _lastName[EmpIDAt];
                BirthDate.Text = _BirthDate[EmpIDAt];
               Gender.Text = _Gender[EmpIDAt];
                Address.Text = _Addresss[EmpIDAt];
                Salary.Text = _Salary[EmpIDAt];
                DeptID.Text = _DeptIDs[EmpIDAt];
                PicturEmp.Load(_PictureFilePath[EmpIDAt]);
                PicturEmp.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else
            {
                MessageBox.Show("Not Found");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files | *.bmp;*.jpg;*.jpeg|PNG File|*.png;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                PicturEmp.Load(openFileDialog1.FileName);
                PicturEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private double AgeCalculate(DateTime birthDate)
        {
            TimeSpan lobjTimeSpan = DateTime.Now.Subtract((DateTime)birthDate);


            double age = lobjTimeSpan.TotalDays / 365.0;
            return age;
        }
        private void SaveToFile()
        {
            string filePath = @"C:\Users\singh\Desktop\Employee\EmployeeRec.dat";



          
           

            using (BinaryWriter IObjBW = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                for(int lncnt=0; lncnt<_firstName.Count; lncnt++)
                {
                    string record = $"|{EmpID[lncnt]}|{_firstName[lncnt]}|{_lastName[lncnt]}|{_BirthDate[lncnt]}|{_Gender[lncnt]}|{_Age[lncnt]}|{_Addresss[lncnt]}|{_Salary[lncnt]}|{_DeptIDs[lncnt]}|{_PictureFilePath[lncnt]}";
                    IObjBW.Write(record+"\n");
                }
                
               
            }


        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            string lsEmpIdAndName = (FindEmp.Text);
            string lsEmpId = lsEmpIdAndName.Split('|')[0];
            bool lbEmpID = (EmpID.Contains(lsEmpId));
            double lnAge = AgeCalculate(DateTime.Parse(BirthDate.Text));
            int EmpIDAt = EmpID.IndexOf(lsEmpId);
            _firstName[EmpIDAt] = FirstName.Text;
            _lastName[EmpIDAt] = LastName.Text;
            _BirthDate[EmpIDAt] = BirthDate.Text;
            _Gender[EmpIDAt] = Gender.Text;
            _Addresss[EmpIDAt] = Address.Text;
            _Salary[EmpIDAt] = Salary.Text;
            _DeptIDs[EmpIDAt] = DeptID.Text;
            _Age[EmpIDAt] = lnAge;
            string FileName = openFileDialog1.FileName;
            if(FileName != "openFileDialog1")
                _PictureFilePath[EmpIDAt] = FileName;


            SaveToFile();
            MessageBox.Show("Update Successfully!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("C:\\Users\\singh\\Desktop\\Employee\\EmployeeRec.dat",
             FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    string EmployeeData = reader.ReadString();
                    string[] EmployeeField = EmployeeData.Split('|');
                    EmpID.Add((EmployeeField[1]));
                    _firstName.Add(EmployeeField[2]);
                    _lastName.Add(EmployeeField[3]);
                    _BirthDate.Add(EmployeeField[4]);
                    _Gender.Add(EmployeeField[5]);
                    _Age.Add(double.Parse(EmployeeField[6]));

                    _Addresss.Add(EmployeeField[7]);
                    _Salary.Add(EmployeeField[8]);
                    _DeptIDs.Add(EmployeeField[9]);
                    _PictureFilePath.Add(EmployeeField[10]);


                }
            }
            for(int lncnt=0; lncnt<EmpID.Count();lncnt++)
            {
                FindEmp.Items.Add(EmpID[lncnt]+"|"+"" + _firstName[lncnt] + " "+_lastName[lncnt]);
            }
        }

        private void FindEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Records_Click(object sender, EventArgs e)
        {

        }

        private void PicturEmp_Click(object sender, EventArgs e)
        {

        }

        private void DeptID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

