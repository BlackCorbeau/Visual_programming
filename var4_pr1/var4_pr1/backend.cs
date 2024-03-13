using System;
using System.IO;

namespace backend
{
    class data
    {
        private string Faculty;
        private string FIO;
        private string abrivature;
        public void Get_Data_faculty(string _faculaty)
        {
            Faculty = _faculaty;
        }
        public void Get_Data_Deas_name(string _Deas_name)
        {
            FIO = _Deas_name;
        }
        public void Get_Data_Abriviation(string _abbriviation)
        {
            abrivature = _abbriviation;
        }
        public void _Create_File()
        {
            using (FileStream itog = new FileStream("C:\\Users\\woron\\source\\repos\\var4_pr1\\var4_pr1\\info.txt", FileMode.Append))
            {
                string Faculty_ = "\nFaculty: ";
                string FIO_ = "Dean's Name: ";
                string abrivature_ = "Abbriviation: ";
                Faculty_ += Faculty;
                Faculty_ += "\n";
                FIO_ += FIO;
                FIO_ += "\n";
                abrivature_ += abrivature;
                abrivature_ += "\n";
                byte[] faculaty_array = System.Text.Encoding.Default.GetBytes(Faculty_);
                byte[] FIO_array = System.Text.Encoding.Default.GetBytes(FIO_);
                byte[] abriviature_array = System.Text.Encoding.Default.GetBytes(abrivature_);

                itog.Write(faculaty_array, 0, faculaty_array.Length);
                itog.Write(FIO_array, 0, FIO_array.Length);
                itog.Write(abriviature_array, 0, abriviature_array.Length);
            }
        }
    }
}