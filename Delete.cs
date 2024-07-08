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
    public partial class Delete : Form
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
        public Delete()
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
        private void SaveToFile()
        {
            string filePath = @"C:\Users\singh\Desktop\Employee\EmployeeRec.dat";






            using (BinaryWriter IObjBW = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                for (int lncnt = 0; lncnt < _firstName.Count; lncnt++)
                {
                    string record = $"|{EmpID[lncnt]}|{_firstName[lncnt]}|{_lastName[lncnt]}|{_BirthDate[lncnt]}|{_Gender[lncnt]}|{_Age[lncnt]}|{_Addresss[lncnt]}|{_Salary[lncnt]}|{_DeptIDs[lncnt]}|{_PictureFilePath[lncnt]}";
                    IObjBW.Write(record);
                }


            }


        }
        private void DeleteRec_Click(object sender, EventArgs e)
        {
            string lsEmpIdAndName = (FindEmp.Text);
            string lsEmpId = lsEmpIdAndName.Split('|')[0];
           

            int EmpIDAt = EmpID.IndexOf(lsEmpId);
            EmpID.RemoveAt(EmpIDAt);
            _firstName.RemoveAt(EmpIDAt);
            _lastName.RemoveAt(EmpIDAt);
            _BirthDate.RemoveAt(EmpIDAt);
            _Gender.RemoveAt(EmpIDAt);
            _Age.RemoveAt(EmpIDAt);    
            _Addresss.RemoveAt(EmpIDAt);
            _Salary.RemoveAt(EmpIDAt);
            _DeptIDs.RemoveAt(EmpIDAt);
            _PictureFilePath.RemoveAt(EmpIDAt);

            SaveToFile();
            MessageBox.Show("Delete Successfully!");
        }

        private void Delete_Load(object sender, EventArgs e)
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
            for (int lncnt = 0; lncnt < EmpID.Count(); lncnt++)
            {
                FindEmp.Items.Add(EmpID[lncnt] + "|" + "" + _firstName[lncnt] + " " + _lastName[lncnt]);
            }
        }
    }
}
