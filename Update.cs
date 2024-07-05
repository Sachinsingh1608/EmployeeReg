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
            int lnEmpIDs = int.Parse(FindEmp.Text);
            if (lnEmpIDs <= _firstName.Count)
            {
                FirstName.Text = _firstName[lnEmpIDs-1];
                LastName.Text = _lastName[lnEmpIDs-1];
                BirthDate.Text = _BirthDate[lnEmpIDs-1];
               Gender.Text = _Gender[lnEmpIDs-1];
                Address.Text = _Addresss[lnEmpIDs-1];
                Salary.Text = _Salary[lnEmpIDs-1];
                DeptID.Text = _DeptIDs[lnEmpIDs - 1];
                PicturEmp.Load(_PictureFilePath[lnEmpIDs-1]);
                PicturEmp.SizeMode = PictureBoxSizeMode.StretchImage;

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
                    IObjBW.Write(record + "\n");
                }
                
               
            }


        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            double lnAge = AgeCalculate(DateTime.Parse(BirthDate.Text));
            int lnEmpIDs = int.Parse(FindEmp.Text);
            _firstName[lnEmpIDs - 1] = FirstName.Text;
            _lastName[lnEmpIDs - 1] = LastName.Text;
            _BirthDate[lnEmpIDs - 1] = BirthDate.Text;
            _Gender[lnEmpIDs - 1] = Gender.Text;
            _Addresss[lnEmpIDs - 1] = Address.Text;
            _Salary[lnEmpIDs - 1] = Salary.Text;
            _DeptIDs[lnEmpIDs - 1] = DeptID.Text;
            _Age[lnEmpIDs - 1] = lnAge;
          
            
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
    }
}

